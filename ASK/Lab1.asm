.386
.model flat, stdcall
.stack 4096

ExitProcess PROTO, dwExitCode:DWORD

.data
myList DWORD 2, 3, 5, 8

.code
main PROC
  mov eax, 7
  add eax, 18
  INVOKE ExitProcess, eax
main ENDP

END main        ;specify the program's entry point