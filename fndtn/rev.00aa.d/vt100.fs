: esc[[ ( -- )
  27 [char] [ swap emit emit ; \ system declared esc[ already!

: up1 ( -- )
  esc[[ 1 emit [char] A emit ;

: down1 ( -- )
  esc[[ 1 emit [char] B emit ;

: left1 ( -- )
  esc[[ 1 emit [char] D emit ;

: mss ( count -- )
  200 * 200 * 0 do 1 drop loop ;

: left ( count -- )
  0 do left1 800 mss loop ;

: up ( count -- )
  0 do up1 loop ;

: down ( count -- )
  0 do down1 loop ;

: saystack cr .s cr ;

: 5As ( -- )
  10 spaces 5 0 do 65 emit loop ;

: 5up ( -- )
  5 0
  do
    up1 43 emit
  loop ;

: gobee saystack ;
: gocee 10 spaces 5 0 do 65 emit loop cr cr ;

: go ( -- )
  5up 5As
  5 up \ 5 0 do up1 loop
  7 0 do 43 emit loop
  cr
  40 spaces
  40 left
;

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
