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

These are the Escape Codes, which in general begin with the ESC
character ASCII 27, 0x1b, octal 33).  The ESC char is usually
followed with a left square bracket char, ASCII 91 (0x5b, oct 133)

    ('escape codes' or 'ansi.sys' codes, are examples of
    two names they may be known by, in common parlance).


BINARY

 Analysis

   ten     hex          binary         octal
   ===    ====    =================    =====
     0    0x00    0 0 0 0   0 0 0 0    0 0 0
     1    0x01    0 0 0 0   0 0 0 1    0 0 1
     2    0x02    0 0 0 0   0 0 1 0    0 0 2
     3    0x03    0 0 0 0   0 0 1 1    0 0 3
     4    0x04    0 0 0 0   0 1 0 0    0 0 4
     5    0x05    0 0 0 0   0 1 0 1    0 0 5
     6    0x06    0 0 0 0   0 1 1 0    0 0 6
     7    0x07    0 0 0 0   0 1 1 1    0 0 7

     8    0x08    0 0 0 0   1 0 0 0    0 1 0
     9    0x09    0 0 0 0   1 0 0 1    0 1 1
    10    0x0a    0 0 0 0   1 0 1 0    0 1 2
    11    0x0b    0 0 0 0   1 0 1 1    0 1 3
    12    0x0c    0 0 0 0   1 1 0 0    0 1 4
    13    0x0d    0 0 0 0   1 1 0 1    0 1 5
    14    0x0e    0 0 0 0   1 1 1 0    0 1 6
    15    0x0f    0 0 0 0   1 1 1 1    0 1 7

    16    0x10    0 0 0 1   0 0 0 0    0 2 0

    27    0x1b    0 0 0 1   1 0 1 1    0 3 3

    27    0x1b    0 0 0   0 1 1   0 1 1    0 3 3
    28    0x1c    0 0 0   0 1 1   1 0 0    0 3 4

0x5b: the '[' char:

    11    0x0b    0 0 0 0   1 0 1 1    0 1 3
    91    0x5b    0 1 0 1   1 0 1 1
    91    0x5b    0 1 0 1 1 0 1 1
    91    0x5b    0 1   0 1 1   0 1 1    1 3 3
    91    0x5b    0 0 1   0 1 1   0 1 1    1 3 3
    28    0x1c    0 0 0   0 1 1   1 0 0    0 3 4
    91    0x5b    0 0 1   0 1 1   0 1 1    1 3 3

    128   64   32   16    8    4    2    1

On branch edits-aa-aa-
Tue Oct  8 07:26:53 UTC 2019
