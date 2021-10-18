.model small
.stack
.code
    mov ah,02h
    mov dl,65 
    mov cx,3
inicio:
    int 21h
    add dl,1  
    loop inicio 
    
    mov ah,4ch
    int 21h
end