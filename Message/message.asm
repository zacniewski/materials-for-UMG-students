.386

.MODEL FLAT, STDCALL

OPTION CASEMAP:NONE

INCLUDE    \masm32\include\windows.inc
INCLUDE    \masm32\include\kernel32.inc
INCLUDELIB \masm32\lib\kernel32.lib
INCLUDE    \masm32\include\user32.inc
INCLUDELIB \masm32\lib\user32.lib

.DATA 

MsgBoxCaption DB "Kurs Iczeliona. Rozdzia³ nr 2",0 
MsgBoxText    DB "Asembler Win32 jest Wspania³y!",0

.CODE 

start: 
    INVOKE MessageBox, NULL, ADDR MsgBoxText, ADDR MsgBoxCaption, MB_OK 
    INVOKE ExitProcess, NULL 
END start 