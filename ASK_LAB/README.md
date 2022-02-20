## Architektura Systemów Komputerowych - przykłady w asemblerze MASM  

#### Szablon programu  
```assembly
.386
.model flat, stdcall
.stack 4096

ExitProcess PROTO, dwExitCode:DWORD		; gdy program musi zakończyć swoje działanie i powrócić do Windows, powinien wywołać funkcję API o nazwie ExitProcess

.data
										; twoje zmienne definiujesz tutaj


.code

main PROC
										; twój kod asemblera piszesz tutaj


	INVOKE ExitProcess, 0				; wywołuje procedurę pod adresem podanym przez wyrażenie
										; zero jest wartością, którą program zwraca do Windows po swoim zakończeniu
main ENDP								; oznacza koniec nazwy procedury, która została wcześniej rozpoczęta przy użyciu proc

END main								; oznacza koniec modułu i opcjonalnie ustawia punkt wejścia programu na main
```

Przed zbudowaniem programu nalezy:  
  - kliknąć prawym klawiszem myszki na nazwę projektu i wybrać 'Build dependencies' -> 'Build customizations',  
  - zaznaczyć opcję 'masm' i kliknąć 'OK',
  - ponownie kliknąć prawym klawiszem myszki na nazwę projektu i wybrać 'Properties' -> 'Configuration Properties' -> 'Linker' -> 'System' -> SubSystem i wybrać 'Windows'.

