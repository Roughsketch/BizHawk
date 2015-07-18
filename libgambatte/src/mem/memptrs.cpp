/***************************************************************************
 *   Copyright (C) 2007-2010 by Sindre Aamås                               *
 *   aamas@stud.ntnu.no                                                    *
 *                                                                         *
 *   This program is free software; you can redistribute it and/or modify  *
 *   it under the terms of the GNU General Public License version 2 as     *
 *   published by the Free Software Foundation.                            *
 *                                                                         *
 *   This program is distributed in the hope that it will be useful,       *
 *   but WITHOUT ANY WARRANTY; without even the implied warranty of        *
 *   MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the         *
 *   GNU General Public License version 2 for more details.                *
 *                                                                         *
 *   You should have received a copy of the GNU General Public License     *
 *   version 2 along with this program; if not, write to the               *
 *   Free Software Foundation, Inc.,                                       *
 *   59 Temple Place - Suite 330, Boston, MA  02111-1307, USA.             *
 ***************************************************************************/
#include "memptrs.h"
#include <algorithm>
#include <cstring>

namespace gambatte {

MemPtrs::MemPtrs()
: rmem_(), wmem_(), romdata_(), wramdata_(), vrambankptr_(0), rsrambankptr_(0),
  wsrambankptr_(0), memchunk_(0), rambankdata_(0), wramdataend_(0), oamDmaSrc_(OAM_DMA_SRC_OFF),
  memchunk_len(0), m_hMapFile(0)
{  
}

MemPtrs::~MemPtrs() {
	UnmapViewOfFile(memchunk_);
	CloseHandle(m_hMapFile);

	UnmapViewOfFile(m_lpSize);
	CloseHandle(m_hMapFileSize);
}

void MemPtrs::reset(const unsigned rombanks, const unsigned rambanks, const unsigned wrambanks) {
	//	Get updated length for memchunk_
	memchunk_len = 0x4000 + rombanks * 0x4000ul + 0x4000 + rambanks * 0x2000ul + wrambanks * 0x1000ul + 0x4000;

	//	If we haven't mapped the file, then map it. Otherwise, zero out the new length to zero.
	//	As far as I'm aware, even if we specify a lower size than the new size initially it
	//  should automatically resize the file on disk with the PAGE_READWRITE flag active.
	if (m_hMapFile == NULL)
	{
		//	Create the new mapped file with the initial length
		m_hMapFile = CreateFileMapping(INVALID_HANDLE_VALUE, NULL, PAGE_READWRITE, 0, memchunk_len, MAP_NAME);

		if (m_hMapFile == NULL)
		{
			wchar_t buffer[256];
			FormatMessage(FORMAT_MESSAGE_FROM_SYSTEM, NULL, GetLastError(), MAKELANGID(LANG_ENGLISH, SUBLANG_ENGLISH_US), buffer, 256, NULL);
			MessageBox(NULL, buffer, L"", 0);
		}

		//	Assign that mapped file's pointer so we can use it
		memchunk_ = (unsigned char *)MapViewOfFile(m_hMapFile, FILE_MAP_ALL_ACCESS, 0, 0, memchunk_len);

		if (memchunk_ == NULL)
		{
			wchar_t buffer[256];
			FormatMessage(FORMAT_MESSAGE_FROM_SYSTEM, NULL, GetLastError(), MAKELANGID(LANG_ENGLISH, SUBLANG_ENGLISH_US), buffer, 256, NULL);
			MessageBox(NULL, buffer, L"", 0);
		}

		//	Create another mapped file to store structured information about the first mapped file
		m_hMapFileSize = CreateFileMapping(INVALID_HANDLE_VALUE, NULL, PAGE_READWRITE, 0, sizeof(int), MAP_INFO_NAME);

		if (m_hMapFileSize == NULL)
		{
			wchar_t buffer[256];
			FormatMessage(FORMAT_MESSAGE_FROM_SYSTEM, NULL, GetLastError(), MAKELANGID(LANG_ENGLISH, SUBLANG_ENGLISH_US), buffer, 256, NULL);
			MessageBox(NULL, buffer, L"", 0);
		}

		//	Assign that pointer so we can use it
		m_lpSize = MapViewOfFile(m_hMapFileSize, FILE_MAP_ALL_ACCESS, 0, 0, sizeof(int));

		if (m_lpSize == NULL)
		{
			wchar_t buffer[256];
			FormatMessage(FORMAT_MESSAGE_FROM_SYSTEM, NULL, GetLastError(), MAKELANGID(LANG_ENGLISH, SUBLANG_ENGLISH_US), buffer, 256, NULL);
			MessageBox(NULL, buffer, L"", 0);
		}
	}
	else
	{
		//	If we've already made the file, then just zero out the old memory
		ZeroMemory(memchunk_, memchunk_len);
	}
	
	//	Copy the structured info into the information mapped file
	CopyMemory((LPVOID)((DWORD)m_lpSize + sizeof(int) * 0), &memchunk_len, sizeof(int));	//	Mapped file length
	CopyMemory((LPVOID)((DWORD)m_lpSize + sizeof(int) * 1), &rombanks, sizeof(int));		//	How many rom banks
	CopyMemory((LPVOID)((DWORD)m_lpSize + sizeof(int) * 2), &rambanks, sizeof(int));		//	How many ram banks
	CopyMemory((LPVOID)((DWORD)m_lpSize + sizeof(int) * 3), &wrambanks, sizeof(int));		//	How many wram banks


	//	Rest of unchanged initialization
	romdata_[0] = romdata();
	rambankdata_ = romdata_[0] + rombanks * 0x4000ul + 0x4000;
	wramdata_[0] = rambankdata_ + rambanks * 0x2000ul;
	wramdataend_ = wramdata_[0] + wrambanks * 0x1000ul;


	std::memset(rdisabledRamw(), 0xFF, 0x2000);

	
	oamDmaSrc_ = OAM_DMA_SRC_OFF;
	rmem_[0x3] = rmem_[0x2] = rmem_[0x1] = rmem_[0x0] = romdata_[0];
	rmem_[0xC] = wmem_[0xC] = wramdata_[0] - 0xC000;
	rmem_[0xE] = wmem_[0xE] = wramdata_[0] - 0xE000;
	setRombank(1);
	setRambank(0, 0);
	setVrambank(0);
	setWrambank(1);

	// we save only the ram areas
	memchunk_saveoffs = vramdata() - memchunk_;
	memchunk_savelen = wramdataend() - memchunk_ - memchunk_saveoffs;
}

void MemPtrs::setRombank0(const unsigned bank) {
	romdata_[0] = romdata() + bank * 0x4000ul;
	rmem_[0x3] = rmem_[0x2] = rmem_[0x1] = rmem_[0x0] = romdata_[0];
	disconnectOamDmaAreas();
}

void MemPtrs::setRombank(const unsigned bank) {
	romdata_[1] = romdata() + bank * 0x4000ul - 0x4000;
	rmem_[0x7] = rmem_[0x6] = rmem_[0x5] = rmem_[0x4] = romdata_[1];
	disconnectOamDmaAreas();
}

void MemPtrs::setRambank(const unsigned flags, const unsigned rambank) {
	unsigned char *const srambankptr = flags & RTC_EN
			? 0
			: (rambankdata() != rambankdataend()
					? rambankdata_ + rambank * 0x2000ul - 0xA000 : wdisabledRam() - 0xA000);

	rsrambankptr_ = (flags & READ_EN) && srambankptr != wdisabledRam() - 0xA000 ? srambankptr : rdisabledRamw() - 0xA000;
	wsrambankptr_ = flags & WRITE_EN ? srambankptr : wdisabledRam() - 0xA000;
	rmem_[0xB] = rmem_[0xA] = rsrambankptr_;
	wmem_[0xB] = wmem_[0xA] = wsrambankptr_;
	disconnectOamDmaAreas();
}

void MemPtrs::setWrambank(const unsigned bank) {
	wramdata_[1] = wramdata_[0] + ((bank & 0x07) ? (bank & 0x07) : 1) * 0x1000;
	rmem_[0xD] = wmem_[0xD] = wramdata_[1] - 0xD000;
	disconnectOamDmaAreas();
}

void MemPtrs::setOamDmaSrc(const OamDmaSrc oamDmaSrc) {
	rmem_[0x3] = rmem_[0x2] = rmem_[0x1] = rmem_[0x0] = romdata_[0];
	rmem_[0x7] = rmem_[0x6] = rmem_[0x5] = rmem_[0x4] = romdata_[1];
	rmem_[0xB] = rmem_[0xA] = rsrambankptr_;
	wmem_[0xB] = wmem_[0xA] = wsrambankptr_;
	rmem_[0xC] = wmem_[0xC] = wramdata_[0] - 0xC000;
	rmem_[0xD] = wmem_[0xD] = wramdata_[1] - 0xD000;
	rmem_[0xE] = wmem_[0xE] = wramdata_[0] - 0xE000;
	
	oamDmaSrc_ = oamDmaSrc;
	disconnectOamDmaAreas();
}

void MemPtrs::disconnectOamDmaAreas() {
	if (isCgb(*this)) {
		switch (oamDmaSrc_) {
		case OAM_DMA_SRC_ROM:  // fall through
		case OAM_DMA_SRC_SRAM:
		case OAM_DMA_SRC_INVALID:
			std::fill(rmem_, rmem_ + 8, static_cast<unsigned char *>(0));
			rmem_[0xB] = rmem_[0xA] = 0;
			wmem_[0xB] = wmem_[0xA] = 0;
			break;
		case OAM_DMA_SRC_VRAM:
			break;
		case OAM_DMA_SRC_WRAM:
			rmem_[0xE] = rmem_[0xD] = rmem_[0xC] = 0;
			wmem_[0xE] = wmem_[0xD] = wmem_[0xC] = 0;
			break;
		case OAM_DMA_SRC_OFF:
			break;
		}
	} else {
		switch (oamDmaSrc_) {
		case OAM_DMA_SRC_ROM:  // fall through
		case OAM_DMA_SRC_SRAM:
		case OAM_DMA_SRC_WRAM:
		case OAM_DMA_SRC_INVALID:
			std::fill(rmem_, rmem_ + 8, static_cast<unsigned char *>(0));
			rmem_[0xB] = rmem_[0xA] = 0;
			wmem_[0xB] = wmem_[0xA] = 0;
			rmem_[0xE] = rmem_[0xD] = rmem_[0xC] = 0;
			wmem_[0xE] = wmem_[0xD] = wmem_[0xC] = 0;
			break;
		case OAM_DMA_SRC_VRAM:
			break;
		case OAM_DMA_SRC_OFF:
			break;
		}
	}
}

// all pointers here are relative to memchunk_
#define MSS(a) RSS(a,memchunk_)
#define MSL(a) RSL(a,memchunk_)

SYNCFUNC(MemPtrs)
{
	/*
	int memchunk_len_old = memchunk_len;
	int memchunk_saveoffs_old = memchunk_saveoffs;
	int memchunk_savelen_old = memchunk_savelen;
	*/

	NSS(memchunk_len);
	NSS(memchunk_saveoffs);
	NSS(memchunk_savelen);

	/*
	if (isReader)
	{
		if (memchunk_len != memchunk_len_old || memchunk_saveoffs != memchunk_saveoffs_old || memchunk_savelen != memchunk_savelen_old)
			__debugbreak();
	}
	*/

	PSS(memchunk_ + memchunk_saveoffs, memchunk_savelen);

	MSS(rmem_[0x0]);
	MSS(wmem_[0x0]);
	MSS(rmem_[0x1]);
	MSS(wmem_[0x1]);
	MSS(rmem_[0x2]);
	MSS(wmem_[0x2]);
	MSS(rmem_[0x3]);
	MSS(wmem_[0x3]);
	MSS(rmem_[0x4]);
	MSS(wmem_[0x4]);
	MSS(rmem_[0x5]);
	MSS(wmem_[0x5]);
	MSS(rmem_[0x6]);
	MSS(wmem_[0x6]);
	MSS(rmem_[0x7]);
	MSS(wmem_[0x7]);
	MSS(rmem_[0x8]);
	MSS(wmem_[0x8]);
	MSS(rmem_[0x9]);
	MSS(wmem_[0x9]);
	MSS(rmem_[0xa]);
	MSS(wmem_[0xa]);
	MSS(rmem_[0xb]);
	MSS(wmem_[0xb]);
	MSS(rmem_[0xc]);
	MSS(wmem_[0xc]);
	MSS(rmem_[0xd]);
	MSS(wmem_[0xd]);
	MSS(rmem_[0xe]);
	MSS(wmem_[0xe]);
	MSS(rmem_[0xf]);
	MSS(wmem_[0xf]);
	//for (int i = 0; i < 0x10; i++)
	//{
	//	MSS(rmem_[i]);
	//	MSS(wmem_[i]);
	//}
	MSS(romdata_[0]);
	MSS(romdata_[1]);
	MSS(wramdata_[0]);
	MSS(wramdata_[1]);
	MSS(vrambankptr_);
	MSS(rsrambankptr_);
	MSS(wsrambankptr_);
	MSS(rambankdata_);
	MSS(wramdataend_);
	NSS(oamDmaSrc_);
}

}
