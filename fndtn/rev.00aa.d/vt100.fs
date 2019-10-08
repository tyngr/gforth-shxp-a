: esc[[ 27 [char] [ swap emit emit ; \ system declared esc[ already!
: go cr 10 spaces 5 0 do 65 emit loop cr cr ;

0 [IF]
  Anything inside this construct is disregarded by gforth
[THEN]

0 [IF]

esc[[ ( -- )
  emits ESC[  (ascii 27, and left square brace)
  as preamble to most vt100 escape sequences to do
  things with the terminal such as reposition the
  cursor, or draw in a different color (or intensity).

[THEN]
