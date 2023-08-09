// See https://aka.ms/new-console-template for more information
// This is the new way of doing a simple hello world.
// Console.WriteLine("Hello, World!");
using System;
using X11;

class Program
{
    static IntPtr display;
    static IntPtr window;

    static void Main(string[] args)
    {
        display = XOpenDisplay(IntPtr.Zero);
        if (display == IntPtr.Zero)
        {
            Console.WriteLine("Failed to open X11 display.");
            return;
        }

        int screen = XDefaultScreen(display);
        IntPtr rootWindow = XRootWindow(display, screen);

        int windowWidth = 400;
        int windowHeight = 300;

        window = XCreateSimpleWindow(
            display, rootWindow,
            0, 0, windowWidth, windowHeight,
            0, XBlackPixel(display, screen), XWhitePixel(display, screen)
        );

        XSelectInput(display, window, XEventMask.ExposureMask | XEventMask.KeyPressMask);
        XMapWindow(display, window);

        while (true)
        {
            XNextEvent(display, out XEvent xEvent);
            switch (xEvent.type)
            {
                case XEventType.Expose:
                    // Handle expose event (window needs to be redrawn)
                    break;
                case XEventType.KeyPress:
                    // Handle key press event
                    Console.WriteLine("Key pressed!");
                    break;
            }
        }
    }

    static void Cleanup()
    {
        XDestroyWindow(display, window);
        XCloseDisplay(display);
    }

    // Import Xlib functions using P/Invoke
    [DllImport("libX11", EntryPoint = "XOpenDisplay")]
    public static extern IntPtr XOpenDisplay(IntPtr display);

    [DllImport("libX11", EntryPoint = "XDefaultScreen")]
    public static extern int XDefaultScreen(IntPtr display);

    [DllImport("libX11", EntryPoint = "XRootWindow")]
    public static extern IntPtr XRootWindow(IntPtr display, int screen);

    [DllImport("libX11", EntryPoint = "XBlackPixel")]
    public static extern ulong XBlackPixel(IntPtr display, int screen);

    [DllImport("libX11", EntryPoint = "XWhitePixel")]
    public static extern ulong XWhitePixel(IntPtr display, int screen);

    [DllImport("libX11", EntryPoint = "XCreateSimpleWindow")]
    public static extern IntPtr XCreateSimpleWindow(
        IntPtr display, IntPtr parent,
        int x, int y, uint width, uint height,
        uint border_width, ulong border, ulong background
    );

    [DllImport("libX11", EntryPoint = "XSelectInput")]
    public static extern int XSelectInput(IntPtr display, IntPtr window, XEventMask eventMask);

    [DllImport("libX11", EntryPoint = "XMapWindow")]
    public static extern void XMapWindow(IntPtr display, IntPtr window);

    [DllImport("libX11", EntryPoint = "XNextEvent")]
    public static extern void XNextEvent(IntPtr display, out XEvent event_return);

    [DllImport("libX11", EntryPoint = "XDestroyWindow")]
    public static extern void XDestroyWindow(IntPtr display, IntPtr window);

    [DllImport("libX11", EntryPoint = "XCloseDisplay")]
    public static extern int XCloseDisplay(IntPtr display);

    // Define XEventMask enum
    [Flags]
    public enum XEventMask : long
    {
        NoEventMask = 0,
        KeyPressMask = 1 << 0,
        KeyReleaseMask = 1 << 1,
        ExposureMask = 1 << 15,
    }

    // Define XEvent struct
    [StructLayout(LayoutKind.Explicit)]
    public struct XEvent
    {
        [FieldOffset(0)]
        public XEventType type;

        // Define other fields as needed based on event type
    }

    // Define XEventType enum
    public enum XEventType
    {
        Expose,
        KeyPress,
        // Define other event types as needed
    }
}
