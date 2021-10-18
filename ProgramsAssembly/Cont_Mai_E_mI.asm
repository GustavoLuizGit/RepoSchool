.model small
.stack
.code
    mov ah,02h
    mov dl,48
inicio:
    int 21h
    add dl,1  
    cmp dl,58
    jnz inicio 
    mov ah,4ch
    int 21h
end