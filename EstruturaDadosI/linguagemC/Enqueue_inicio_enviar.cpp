 void Enqueue_inicio(Fila *F, int X)
{
    F->Com--;
    if (F->Com<0)
        F->Com=TAM-1;
    F->M[F->Com]=X;
    F->Total++;
}
