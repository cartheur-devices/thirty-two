# Personal Area Networking for .NET v2.5

Old code to support Bluetooth communication in CF.

Build 2.5.0125 25th January 2010

This library provides a .NET networking API for devices and desktop computers running the Microsoft Bluetooth stack, Microsoft Windows supported IrDA devices and associated Object Exchange (OBEX) services for both these mediums. Online documentation is integrated into your Visual Studio help. The object model has been designed to promote consistency between Bluetooth, IrDA and traditional TCP/IP networking.

_Supported Platforms_
*	.NET Framework v2.0 / v3.0 / v3.5
*	.NET Compact Framework v2.0 / v3.5
*	Windows XP SP2 and above
*	Windows Vista
*   Windows CE 4.2 and above
*	Windows Mobile 2003 and above
*	Only the Microsoft and Broadcom/Widcomm Bluetooth stacks are supported - this library will not work with other third-party stacks.

### Tools
Requires Visual Studio 2005 / 2008.

_Samples_
* BluetoothChat - Multiplatform chat application, versions for Smartphone, Pocket PC and Desktop
* BluetoothRemote - Desktop listener and Smartphone client, forwards button presses to the desktop, can be used to remotely control Powerpoint etc
* BluetoothSDP –Showcases SDP parsing.
* ObexPush - Used to send any file object to an available device over Bluetooth or IrDA
* ObjectPushVB – Visual Basic device project (VS2003)
* DesktopObexListener - Listens for and stores incoming objects (Designed for use on a Windows XP/Vista machine)
* DeviceObexListener – Pocket PC equivalent (Turn off default Beam option on device for this to run)
* IrDAServiceClient – Shows the IrDA functionality available for desktop Windows
