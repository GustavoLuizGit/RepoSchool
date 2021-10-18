.model small
.stack
.code   
    mov ah,02h
    mov dl,48
    mov cx,10
inicio:
    int 21h
    add dl,1
    loop inicio
end