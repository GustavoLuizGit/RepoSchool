﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Projeto_3
{
    class Cadastro
    {
        private string nome;
        private Bitmap img1;
        private Bitmap img2;

        public string Nome { get => nome; set => nome = value; }
        public Bitmap Img1 { get => img1; set => img1 = value; }
        public Bitmap Img2 { get => img2; set => img2 = value; }
    }
}
