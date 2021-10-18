.model small
.stack
.code 
    mov ax,12
    mov bx,2
    mov cx,0
    repita:
    mov dx,0 
    div bx
    push dx
    inc cx
    cmp ax,0
    jne repita  
    
    repita2:
    pop dx 
    add dl,48
    mov ah,02h
    int 21h
    loop repita2    
    
    mov ah,4ch
    int 21h 
    
    
    
    
end