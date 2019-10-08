: esc[[ ( -- )
  27 [char] [ swap emit emit ; \ system declared esc[ already!

: bkblue ( -- n1 n2)
  [char] 4 [char] 4 swap
;

: white ( -- n1 n2 )
  [char] 3 [char] 7 swap
;

: cyan ( -- n1 n2 )
  [char] 3 [char] 6 swap
;

: magenta ( -- n1 n2 )
  [char] 3 [char] 5 swap
;

: blue ( -- n1 n2 )
  [char] 3 [char] 4 swap
;

: yellow ( -- n1 n2 )
  [char] 3 [char] 3 swap
;

: green ( -- n1 n2 )
  [char] 3 [char] 2 swap
;

: red ( -- n1 n2 )
  [char] 3 [char] 1 swap
;

: colpost ( -- )
  [char] m emit ;

: colpre ( -- )
  esc[[
  [char] 0 emit
;

: nocolor colpre colpost
;

: brtcol ( -- )
  esc[[
  [char] 1 emit
;

: color ( n1 n2 -- )
  colpre
  [char] ; emit
  \ [char] 1 emit
  \ [char] ; emit
  \ color on stack
  \ [char] 3 [char] 2 swap emit emit
  emit emit
  colpost
;

: up1 ( -- )
  esc[[ 1 emit [char] A emit ;

: down1 ( -- )
  esc[[ 1 emit [char] B emit ;

: left1 ( -- )
  esc[[ 1 emit [char] D emit ;

: right1 ( -- )
  esc[[ 1 emit [char] C emit ;

: mss ( count -- )
  200 * 200 * 0 do 1 drop loop ;

: up ( count -- )
  0 do up1 loop ;

: down ( count -- )
  0 do down1 loop ;

: left ( count -- )
  0 do left1 800 mss loop ;

: right ( count -- )
  0 do right1 800 mss loop ;

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
  nocolor
  2 up
  bkblue color
  5up 5As
  5 up \ 5 0 do up1 loop
  magenta color
  7 0 do 43 emit loop
  nocolor
  cr
  40 spaces
  40 left
  2000 mss
  40 right
  \ red
  \ green
  \ blue
  \ yellow
  \ magenta
  \ cyan
  bkblue color
  green color
  3 0 do
    43 emit 300 mss
  loop
  nocolor
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
