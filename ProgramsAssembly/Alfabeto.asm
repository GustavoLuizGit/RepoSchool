.model small
.stack
.code
    mov ah,02h
    mov dl,65
inicio:
    int 21h
    add dl,1  
    cmp dl,91
    jnz inicio 
    
    mov ah,4ch
    int 21h
end