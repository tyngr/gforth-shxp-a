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

On branch edits-aa-aa-
Tue Oct  8 05:44:04 UTC 2019
