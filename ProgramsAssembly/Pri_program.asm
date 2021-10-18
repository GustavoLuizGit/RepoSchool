;impriindo um caractere na tela
.model small
.stack
.code
    mov ah,02h
    mov dl,71
    int 21h
    mov dl,117
    int 21h
    mov dl,115
    int 21h
    mov dl,116
    int 21h
    mov dl,97
    int 21h
    mov dl,118
    int 21h
    mov dl,111
    int 21h
    
    mov ah,4ch
    int 21h
end