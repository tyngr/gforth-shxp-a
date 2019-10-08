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

NOTE: VT100 may not be (at all) correct, here .. is assumed
for this (brief) writing period.  VT220 almost certainly
obtains.  ANSI.SYS style/commands are of most direct experience.


The VT100 family of serial terminals accepts a wide variety
of emission inputs, in the form of ASCII characters sent to
the terminal, from the serial device (such as a MODEM, or
more generally, the device called '/dev/ttyS0' in Linux - as
well as other similar 'tty' devices).


This program demonstrates both ordinary typewritten characters
(a b c d e 9 8 7 6 5 + - , > < = and all the rest) as generated
by gforth, primarily using the (gforth) 'emit' word, which (in
general) sends the corresponding ASCII code to the controlling
terminal connected to gforth's interpreter.

More to the point, the program intends to incorporate the basic
vt100 codes used to reposition the terminal's cursor -- and thus,
allow 'full screen' use of the terminal, rather than line-by-line
uses, where the terminal never goes back to the previous line for
any reason (as with some early teleprinters).


On branch edits-aa-aa-
Tue Oct  8 07:26:53 UTC 2019
