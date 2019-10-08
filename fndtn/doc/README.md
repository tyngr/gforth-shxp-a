SUMMARY

 Simple vt-100 output

    The VT100 serial terminal displays text information sent to
    it, by a variety of methods, generally responding to so-called
    ASCII codes (and more complex codes, based on trapped sequences
    of ASCII that must be sent contiguously to the terminal's input
    channel).

    This program 'emits' single ASCII characters to the VT100 family
    of serial terminals (including 'xterm' in Linux, which has a
    family resemblance to VT100, though somewhat, if not fully
    virtualized).

    Future versions of this program will emit ASCII sequences to
    the VT100, generally to reposition the terminal's cursor, to
    draw text information on the terminal at arbitrary horizontal
    and vertical offsets.


DETAILS

The VT100 family of serial terminals accepts a wide variety
of emission inputs, in the form of ASCII characters sent to
the terminal, from the serial device (such as a MODEM, or
more generally, the device called '/dev/ttyS0' in Linux - as
well as other similar 'tty' devices).

On branch edits-aa-aa-
Tue Oct  8 05:52:22 UTC 2019
