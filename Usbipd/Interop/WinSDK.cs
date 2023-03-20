﻿// SPDX-FileCopyrightText: 2020 Frans van Dorsselaer
//
// SPDX-License-Identifier: GPL-3.0-only

using System;
using Windows.Win32;

namespace Usbipd.Interop;

/// <summary>
/// The remaining Windows SDK stuff that is not (yet?) exposed by CsWin32. Bitfields, for example.
/// </summary>
static class WinSDK
{
    /// <summary>WinSDK: usbioctl.h: USB_PROTOCOLS</summary>
    [Flags]
    public enum UsbProtocols : uint
    {
        None = 0,
        Usb110 = (1 << 0),
        Usb200 = (1 << 1),
        Usb300 = (1 << 2),
    }

    /// <summary>WinSDK: usbioctl.h: USB_NODE_CONNECTION_INFORMATION_EX_V2_FLAGS</summary>
    [Flags]
    public enum UsbNodeConnectionInformationExV2Flags : uint
    {
        DeviceIsOperatingAtSuperSpeedOrHigher = (1 << 0),
        DeviceIsSuperSpeedCapableOrHigher = (1 << 1),
        DeviceIsOperatingAtSuperSpeedPlusOrHigher = (1 << 2),
        DeviceIsSuperSpeedPlusCapableOrHigher = (1 << 3),
    }

    /// <summary>WinSDK: setupapi.h: ERROR_NO_DRIVER_SELECTED</summary>
    public const uint ERROR_NO_DRIVER_SELECTED = PInvoke.APPLICATION_ERROR_MASK | PInvoke.ERROR_SEVERITY_ERROR | 0x203;
}
