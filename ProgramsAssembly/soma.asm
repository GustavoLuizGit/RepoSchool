.model smal
.stack
.code 
    mov ax,3
    mov bx,4
    mul bx ;ax = ax * bx
    
    mov ah,4ch
    int 21h
end. 