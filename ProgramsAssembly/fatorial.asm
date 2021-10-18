.model small
.stack
.code 
    mov ax,4
    call fatorial            
    call writei  
             
    mov ah,4ch   
    int 21h
    
fatorial proc
    push cx
    mov cx,ax
    dec cx
    repita:   
    imul cx ;ax = ax * bx
    loop repita
    pop cx   
    ret
fatorial endp
    
writei proc 
    push ax
    push bx
    push cx
    push dx ;tira uma copia dos valores e manda pra uma pilha
    
    
    mov cx,0
    mov bx,10  
    repitawi1:
    mov dx,0
    div bx   ;dx:ax e dividido por bx, o resto e armazenado no dx e o quociente em ax 
    push dx  ; armazena em ss que é o segmento de pilha
    inc cx
    cmp ax,0
    jne repitawi1 ;se ax nao e igual a 0 volta pro repitawi
    
    repitawi2:
    pop dx ;manda pro registrador dl
    add dl,48
    mov ah,02h
    int 21h
    loop repitawi2 
    
    pop dx
    pop cx
    pop bx
    pop ax ; restaura os registradores com os valores que entro na funcao
    ret
writei endp

end