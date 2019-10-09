#!/bin/sh

if ! [ ${TERM}x = "xtermx" ]
  then
    echo "Your current \$TERM is ${TERM}"
    echo "(Program designed around xterm)"
    echo "Exiting."
    sleep 1 ; exit 1
fi

# - - - -   main   - - - -
./forth.sh go 9 up
echo "                      sleeping"
sleep 1

# Wed Oct  9 08:13:26 UTC 2019
