﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _18GhostsGame
{
    enum Symbols
    {
        blank = ' ',
        carpet = '·',
        column = '|',
        mirrors = '¤',
        portalUp = '↑',
        portalDown = '↓',
        portalLeft = '←',
        portalRight = '→',

        ghosts1P1 = 'a',
        ghosts2P1 = 'b',
        ghosts3P1 = 'c',

        ghosts1P2 = 'ɐ',  
        ghosts2P2 = 'q',
        ghosts3P2 = 'ɔ'
    }
}

/*
mirrors: 7, 9, 17, 19
rPortal:3
yPortal:15
bPortal:23
 _____ _____ _____ _____ _____ _____ 
|1    |2    |3    |4    |5    |     |
|  b  |  r  | rP  |  b  |  r  |  D  |
|_____|_____|_____|_____|_____|     |
|6    |7    |8    |9    |10   |  U  |
|  y  |  M  |  y  |  M  |  y  |     |
|_____|_____|_____|_____|_____|  N  |
|11   |12   |13   |14   |15   |     |
|  r  |  b  |  r  |  b  | yP  |  G  |
|_____|_____|_____|_____|_____|     |
|16   |17   |18   |19   |20   |  E  |
|  b  |  M  |  y  |  M  |  r  |     |
|_____|_____|_____|_____|_____|  O  |
|21   |22   |23   |24   |25   |     |
|  y  |  r  | bP  |  b  |  y  |  N  |
|_____|_____|_____|_____|_____|_____|
*/
