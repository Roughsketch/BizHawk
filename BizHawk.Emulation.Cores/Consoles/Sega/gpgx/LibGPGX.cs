﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace BizHawk.Emulation.Cores.Consoles.Sega.gpgx
{
	public static class LibGPGX
	{
		[DllImport("libgenplusgx.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern void gpgx_get_video(ref int w, ref int h, ref int pitch, ref IntPtr buffer);

		[DllImport("libgenplusgx.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern void gpgx_get_audio(ref int n, ref IntPtr buffer);

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate int load_archive_cb(string filename, IntPtr buffer, int maxsize);

		[DllImport("libgenplusgx.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern void gpgx_advance();

		[DllImport("libgenplusgx.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern bool gpgx_init(string feromextension, load_archive_cb feload_archive_cb, bool sixbutton, INPUT_SYSTEM system_a, INPUT_SYSTEM system_b);

		[DllImport("libgenplusgx.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern void gpgx_get_fps(ref int num, ref int den);

		[DllImport("libgenplusgx.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern int gpgx_state_size();
		[DllImport("libgenplusgx.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern bool gpgx_state_save(byte[] dest, int size);
		[DllImport("libgenplusgx.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern bool gpgx_state_load(byte[] src, int size);

		[DllImport("libgenplusgx.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern bool gpgx_get_control(IntPtr dest, int bytes);
		[DllImport("libgenplusgx.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern bool gpgx_put_control(IntPtr src, int bytes);

		public static bool gpgx_get_control(InputData dest)
		{
			int bytes = Marshal.SizeOf(typeof(InputData));
			IntPtr p = Marshal.AllocHGlobal(bytes);

			bool succeed = gpgx_get_control(p, bytes);
			if (succeed)
				Marshal.PtrToStructure(p, dest);
			Marshal.FreeHGlobal(p);
			return succeed;
		}

		public static bool gpgx_put_control(InputData src)
		{
			int bytes = Marshal.SizeOf(typeof(InputData));
			IntPtr p = Marshal.AllocHGlobal(bytes);

			Marshal.StructureToPtr(src, p, false);

			bool succeed = gpgx_put_control(p, bytes);
			Marshal.FreeHGlobal(p);
			return succeed;
		}

		public const int MAX_DEVICES = 8;

		public enum INPUT_SYSTEM : byte
		{
			SYSTEM_NONE = 0,		// unconnected port	
			SYSTEM_MD_GAMEPAD = 1,	// single 3-buttons or 6-buttons Control Pad 	
			SYSTEM_MOUSE = 2,		// Sega Mouse 	
			SYSTEM_MENACER = 3,		// Sega Menacer -- port B only
			SYSTEM_JUSTIFIER = 4,	// Konami Justifiers -- port B only
			SYSTEM_XE_A1P = 5,		// XE-A1P analog controller -- port A only
			SYSTEM_ACTIVATOR = 6,	// Sega Activator 	
			SYSTEM_MS_GAMEPAD = 7,	// single 2-buttons Control Pad -- Master System
			SYSTEM_LIGHTPHASER = 8,	// Sega Light Phaser -- Master System
			SYSTEM_PADDLE = 9,		// Sega Paddle Control -- Master System
			SYSTEM_SPORTSPAD = 10,	// Sega Sports Pad -- Master System
			SYSTEM_TEAMPLAYER = 11,	// Multi Tap -- Sega TeamPlayer 	
			SYSTEM_WAYPLAY = 12,	// Multi Tap -- EA 4-Way Play -- use both ports
		};

		public enum INPUT_DEVICE : byte
		{
			DEVICE_NONE = 0xff,		// unconnected device = fixed ID for Team Player)
			DEVICE_PAD3B = 0x00,	// 3-buttons Control Pad = fixed ID for Team Player)
			DEVICE_PAD6B = 0x01,	// 6-buttons Control Pad = fixed ID for Team Player)
			DEVICE_PAD2B = 0x02,	// 2-buttons Control Pad
			DEVICE_MOUSE = 0x03,	// Sega Mouse
			DEVICE_LIGHTGUN = 0x04, // Sega Light Phaser, Menacer or Konami Justifiers
			DEVICE_PADDLE = 0x05,	// Sega Paddle Control
			DEVICE_SPORTSPAD = 0x06,// Sega Sports Pad
			DEVICE_PICO = 0x07,		// PICO tablet
			DEVICE_TEREBI = 0x08,	// Terebi Oekaki tablet
			DEVICE_XE_A1P = 0x09,	// XE-A1P analog controller
			DEVICE_ACTIVATOR = 0x0a,// Activator
		};

		/// <summary>
		/// not every flag is valid for every device!
		/// </summary>
		[Flags]
		public enum INPUT_KEYS : ushort
		{
			/* Default Input bitmasks */
			INPUT_MODE = 0x0800,
			INPUT_X = 0x0400,
			INPUT_Y = 0x0200,
			INPUT_Z = 0x0100,
			INPUT_START = 0x0080,
			INPUT_A = 0x0040,
			INPUT_C = 0x0020,
			INPUT_B = 0x0010,
			INPUT_RIGHT = 0x0008,
			INPUT_LEFT = 0x0004,
			INPUT_DOWN = 0x0002,
			INPUT_UP = 0x0001,

			/* Master System specific bitmasks */
			INPUT_BUTTON2 = 0x0020,
			INPUT_BUTTON1 = 0x0010,

			/* Mega Mouse specific bitmask */
			INPUT_MOUSE_CENTER = 0x0040,
			INPUT_MOUSE_RIGHT = 0x0020,
			INPUT_MOUSE_LEFT = 0x0010,

			/* Pico hardware specific bitmask */
			INPUT_PICO_PEN = 0x0080,
			INPUT_PICO_RED = 0x0010,

			/* XE-1AP specific bitmask */
			INPUT_XE_E1 = 0x0800,
			INPUT_XE_E2 = 0x0400,
			INPUT_XE_START = 0x0200,
			INPUT_XE_SELECT = 0x0100,
			INPUT_XE_A = 0x0080,
			INPUT_XE_B = 0x0040,
			INPUT_XE_C = 0x0020,
			INPUT_XE_D = 0x0010,

			/* Activator specific bitmasks */
			INPUT_ACTIVATOR_8U = 0x8000,
			INPUT_ACTIVATOR_8L = 0x4000,
			INPUT_ACTIVATOR_7U = 0x2000,
			INPUT_ACTIVATOR_7L = 0x1000,
			INPUT_ACTIVATOR_6U = 0x0800,
			INPUT_ACTIVATOR_6L = 0x0400,
			INPUT_ACTIVATOR_5U = 0x0200,
			INPUT_ACTIVATOR_5L = 0x0100,
			INPUT_ACTIVATOR_4U = 0x0080,
			INPUT_ACTIVATOR_4L = 0x0040,
			INPUT_ACTIVATOR_3U = 0x0020,
			INPUT_ACTIVATOR_3L = 0x0010,
			INPUT_ACTIVATOR_2U = 0x0008,
			INPUT_ACTIVATOR_2L = 0x0004,
			INPUT_ACTIVATOR_1U = 0x0002,
			INPUT_ACTIVATOR_1L = 0x0001,
		};

		[StructLayout(LayoutKind.Sequential)]
		public class InputData
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
			public readonly INPUT_SYSTEM[] system = new INPUT_SYSTEM[2];
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MAX_DEVICES)]
			public readonly INPUT_DEVICE[] dev = new INPUT_DEVICE[MAX_DEVICES];
			/// <summary>
			/// digital inputs
			/// </summary>
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MAX_DEVICES)]
			public readonly INPUT_KEYS[] pad = new INPUT_KEYS[MAX_DEVICES];
			/// <summary>
			/// analog (x/y)
			/// </summary>
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MAX_DEVICES * 2)]
			public readonly short[,] analog = new short[MAX_DEVICES, 2];
			/// <summary>
			/// gun horizontal offset
			/// </summary>
			public int x_offset;
			/// <summary>
			/// gun vertical offset
			/// </summary>
			public int y_offset;

			public void ClearAllBools()
			{
				for (int i = 0; i < pad.Length; i++)
					pad[i] = 0;
			}
		}


	}
}