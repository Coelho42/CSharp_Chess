using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Xadrez
{
    public partial class Tabuleiro : Form
    {

        Peca[,] tabuleiro = new Peca[8, 8];
        Size pictureBoxSize = new Size(70, 70);
        int coordenadaX = 10;                                          //Localização inicial das pictureBoxes do tabuleiro no X
        int coordenadaY = 0;                                           //Localização inicial das pictureBoxes do tabuleiro no Y

        Peca origemPeca;
        Peca destinoPeca;
        Point pecaOrigemLocalizacao;
        Image pecaOrigemImage;
        Color CorTransparente;

        bool PodeMover;
        bool firstPieceClicked = false;
        bool player1Turn = true;
        bool podeComer;

        public Tabuleiro()
        {
            InitializeComponent();
        }

        private void Tabuleiro_Load(object sender, EventArgs e)
        {
            desenhaTabuleiro();
        }

        public void desenhaTabuleiro()
        {
            for (int i = 0; i < tabuleiro.GetLength(0); i++)
            {
                for (int j = 0; j < tabuleiro.GetLength(1); j++)
                {

                    tabuleiro[i, j] = new Peca();
                    tabuleiro[i, j].setcolourBlack(null);

                    //Preenche os espaços sem peças
                    tabuleiro[i, j].Click += pieceClick;

                    //Verifica se o i é 0
                    if (i == 0)
                    {
                        //Verifica se o j é 0 ou 7
                        if (j == 0 || j == 7)
                        {
                            tabuleiro[i, j] = new Torre();
                            tabuleiro[i, j].setcolourBlack(true);
                            tabuleiro[i, j].setpieceName("Torre");
                            tabuleiro[i, j].Image = Xadrez.Properties.Resources.BlackRook;
                            tabuleiro[i, j].Click += pieceClick;
                        }

                        //Verifica se o j é 1 ou 6
                        if (j == 1 || j == 6)
                        {
                            tabuleiro[i, j] = new Cavalo();
                            tabuleiro[i, j].setcolourBlack(true);
                            tabuleiro[i, j].setpieceName("Cavalo");
                            tabuleiro[i, j].Image = Xadrez.Properties.Resources.BlackKnight;
                            tabuleiro[i, j].Click += pieceClick;
                        }

                        //Verifica se o j é 2 ou 5
                        if (j == 2 || j == 5)
                        {
                            tabuleiro[i, j] = new Bispo();
                            tabuleiro[i, j].setcolourBlack(true);
                            tabuleiro[i, j].setpieceName("Bispo");
                            tabuleiro[i, j].Image = Xadrez.Properties.Resources.BlackBishop;
                            tabuleiro[i, j].Click += pieceClick;
                        }

                        //Verifica se o j é 3
                        if (j == 3)
                        {
                            tabuleiro[i, j] = new Rainha();
                            tabuleiro[i, j].setcolourBlack(true);
                            tabuleiro[i, j].setpieceName("Rainha");
                            tabuleiro[i, j].Image = Xadrez.Properties.Resources.BlackQueen;
                            tabuleiro[i, j].Click += pieceClick;
                        }

                        //Verifica se o j é 4
                        if (j == 4)
                        {
                            tabuleiro[i, j] = new Rei();
                            tabuleiro[i, j].setcolourBlack(true);
                            tabuleiro[i, j].setpieceName("Rei");
                            tabuleiro[i, j].Image = Xadrez.Properties.Resources.BlackKing;
                            tabuleiro[i, j].Click += pieceClick;
                        }
                    }

                    //Verifica se o i é 1
                    if (i == 1)
                    {
                        tabuleiro[i, j] = new Peao();
                        tabuleiro[i, j].setcolourBlack(true);
                        tabuleiro[i, j].setpieceName("Peão");
                        tabuleiro[i, j].Image = Xadrez.Properties.Resources.BlackPawn;
                        tabuleiro[i, j].Click += pieceClick;
                    }

                    //Verifica se o i é 6
                    if (i == 6)
                    {
                        tabuleiro[i, j] = new Peao();
                        tabuleiro[i, j].setcolourBlack(false);
                        tabuleiro[i, j].setpieceName("Peão");
                        tabuleiro[i, j].Image = Xadrez.Properties.Resources.WhitePawn;
                        tabuleiro[i, j].Click += pieceClick;
                    }

                    //Verifica se o i é 7
                    if (i == 7)
                    {
                        //Verifica se o j é 0 ou 7
                        if (j == 0 || j == 7)
                        {
                            tabuleiro[i, j] = new Torre();
                            tabuleiro[i, j].setcolourBlack(false);
                            tabuleiro[i, j].setpieceName("Torre");
                            tabuleiro[i, j].Image = Xadrez.Properties.Resources.WhiteRook;
                            tabuleiro[i, j].Click += pieceClick;
                        }

                        //Verifica se o j é 1 ou 6
                        if (j == 1 || j == 6)
                        {
                            tabuleiro[i, j] = new Cavalo();
                            tabuleiro[i, j].setcolourBlack(false);
                            tabuleiro[i, j].setpieceName("Cavalo");
                            tabuleiro[i, j].Image = Xadrez.Properties.Resources.WhiteKnight;
                            tabuleiro[i, j].Click += pieceClick;

                        }

                        //Verifica se o j é 2 ou 5
                        if (j == 2 || j == 5)
                        {
                            tabuleiro[i, j] = new Bispo();
                            tabuleiro[i, j].setcolourBlack(false);
                            tabuleiro[i, j].setpieceName("Bispo");
                            tabuleiro[i, j].Image = Xadrez.Properties.Resources.WhiteBishop;
                            tabuleiro[i, j].Click += pieceClick;
                        }

                        //Verifica se o j é 4
                        if (j == 3)
                        {
                            tabuleiro[i, j] = new Rainha();
                            tabuleiro[i, j].setcolourBlack(false);
                            tabuleiro[i, j].setpieceName("Rainha");
                            tabuleiro[i, j].Image = Xadrez.Properties.Resources.WhiteQueen;
                            tabuleiro[i, j].Click += pieceClick;
                        }

                        //Verifica se o j é 3
                        if (j == 4)
                        {
                            tabuleiro[i, j] = new Rei();
                            tabuleiro[i, j].setcolourBlack(false);
                            tabuleiro[i, j].setpieceName("Rei");
                            tabuleiro[i, j].Image = Xadrez.Properties.Resources.WhiteKing;
                            tabuleiro[i, j].Click += pieceClick;
                        }
                    }

                    //Verifica se o valor de i é par
                    if (i % 2 == 0)
                    {
                        //Verifica se o valor de j é par
                        if (j % 2 == 0)
                        {
                            tabuleiro[i, j].BackColor = Color.DarkRed;
                        }
                        else
                        {
                            tabuleiro[i, j].BackColor = Color.LightGray;
                        }
                    }
                    else
                    {
                        //Verifica se o valor de j é par
                        if (j % 2 == 0)
                        {
                            tabuleiro[i, j].BackColor = Color.LightGray;
                        }
                        else
                        {
                            tabuleiro[i, j].BackColor = Color.DarkRed;
                        }
                    }

                    tabuleiro[i, j].Size = pictureBoxSize;          //Dá o valor do Size previamente definido à PictureBox
                    tabuleiro[i, j].Location = new Point(coordenadaX, coordenadaY);     //Dá o valor da localização previamente definido à PictureBox
                    coordenadaX += 70;        //Incrementa o valor do X da localização

                    tabuleiro[i, j].SizeMode = PictureBoxSizeMode.CenterImage;     //Define o modo de apresentação da imagem de cada PictureBox
                    panelFill.Controls.Add(tabuleiro[i, j]);                        //Adiciona a PictureBox ao panelFill(painel do meio)
                }
                coordenadaX = 10;             //Reseta o valor de X
                coordenadaY += 70;            //Incrementa o valor de Y
            }
        }

        private void pieceClick(object sender, EventArgs e)
        {
            if (player1Turn == true)
            {
                if (firstPieceClicked == false)
                {
                    origemPeca = (Peca)sender;
                    if (origemPeca.getcolourBlack() == true)
                    {
                        pecaOrigemLocalizacao = origemPeca.Location;
                        pecaOrigemImage = origemPeca.Image;
                        CorTransparente = origemPeca.BackColor;
                        origemPeca.BackColor = Color.Green;
                        sender = origemPeca;
                        firstPieceClicked = true;
                    }
                }
                else
                {
                    if (player1Turn == true)
                    {
                        destinoPeca = (Peca)sender;

                        if (destinoPeca.getcolourBlack() == null || false)
                        {
                            if (origemPeca.getpieceName() == "Peão")
                            {
                                origemPeca = new Peao();
                                PodeMover = origemPeca.Mover(tabuleiro, pecaOrigemLocalizacao, destinoPeca.Location, player1Turn);
                                podeComer = origemPeca.Comer(tabuleiro, pecaOrigemLocalizacao, destinoPeca.Location, player1Turn);

                                if (destinoPeca.getcolourBlack() == null && PodeMover == true)
                                {
                                    destinoPeca.setpieceName("Peão");
                                    destinoPeca.setcolourBlack(true);
                                    destinoPeca.Image = pecaOrigemImage;
                                    sender = destinoPeca;

                                    for (int i = 0; i < tabuleiro.GetLength(0); i++)
                                    {
                                        for (int j = 0; j < tabuleiro.GetLength(1); j++)
                                        {
                                            if (tabuleiro[i, j].Location == pecaOrigemLocalizacao)
                                            {
                                                tabuleiro[i, j].BackColor = CorTransparente;
                                                tabuleiro[i, j].Image = null;
                                                tabuleiro[i, j].setcolourBlack(null);
                                                tabuleiro[i, j].setpieceName(null);
                                            }
                                        }
                                    }
                                    firstPieceClicked = false;
                                    player1Turn = false;
                                }
                                else if (destinoPeca.getcolourBlack() == false && PodeMover == true)
                                {
                                    destinoPeca.setpieceName("Peão");
                                    destinoPeca.setcolourBlack(true);
                                    destinoPeca.Image = pecaOrigemImage;
                                    sender = destinoPeca;

                                    for (int i = 0; i < tabuleiro.GetLength(0); i++)
                                    {
                                        for (int j = 0; j < tabuleiro.GetLength(1); j++)
                                        {
                                            if (tabuleiro[i, j].Location == pecaOrigemLocalizacao)
                                            {
                                                tabuleiro[i, j].BackColor = CorTransparente;
                                                tabuleiro[i, j].Image = null;
                                                tabuleiro[i, j].setcolourBlack(null);
                                                tabuleiro[i, j].setpieceName(null);
                                            }
                                        }
                                    }
                                    firstPieceClicked = false;
                                    player1Turn = false;
                                }
                                else
                                {
                                    for (int i = 0; i < tabuleiro.GetLength(0); i++)
                                    {
                                        for (int j = 0; j < tabuleiro.GetLength(1); j++)
                                        {
                                            if (tabuleiro[i, j].Location == pecaOrigemLocalizacao)
                                            {
                                                tabuleiro[i, j].BackColor = CorTransparente;
                                            }
                                        }
                                    }
                                    firstPieceClicked = false;
                                }
                            }
                            if (player1Turn == true)
                            {
                                // Knight
                                if (origemPeca.getpieceName() == "Cavalo")
                                {
                                    origemPeca = new Cavalo();
                                    PodeMover = origemPeca.Mover(tabuleiro, pecaOrigemLocalizacao, destinoPeca.Location, player1Turn);

                                    if (PodeMover)
                                    {
                                        destinoPeca.setpieceName("Cavalo");
                                        destinoPeca.setcolourBlack(true);
                                        destinoPeca.Image = pecaOrigemImage;
                                        sender = destinoPeca;

                                        for (int i = 0; i < tabuleiro.GetLength(0); i++)
                                        {
                                            for (int j = 0; j < tabuleiro.GetLength(1); j++)
                                            {
                                                if (tabuleiro[i, j].Location == pecaOrigemLocalizacao)
                                                {
                                                    tabuleiro[i, j].BackColor = CorTransparente;
                                                    tabuleiro[i, j].Image = null;
                                                    tabuleiro[i, j].setcolourBlack(null);
                                                    tabuleiro[i, j].setpieceName(null);
                                                }
                                            }
                                        }
                                        firstPieceClicked = false;
                                        player1Turn = false;
                                    }
                                    else
                                    {
                                        for (int i = 0; i < tabuleiro.GetLength(0); i++)
                                        {
                                            for (int j = 0; j < tabuleiro.GetLength(1); j++)
                                            {
                                                if (tabuleiro[i, j].Location == pecaOrigemLocalizacao)
                                                {
                                                    tabuleiro[i, j].BackColor = CorTransparente;
                                                }
                                            }
                                        }
                                        firstPieceClicked = false;
                                    }
                                }
                            }
                            if (player1Turn == true)
                            {
                                // Bispo
                                if (origemPeca.getpieceName() == "Bispo")
                                {
                                    origemPeca = new Bispo();
                                    PodeMover = origemPeca.Mover(tabuleiro, pecaOrigemLocalizacao, destinoPeca.Location, player1Turn);

                                    if (PodeMover)
                                    {
                                        destinoPeca.setpieceName("Bispo");
                                        destinoPeca.setcolourBlack(true);
                                        destinoPeca.Image = pecaOrigemImage;
                                        sender = destinoPeca;

                                        for (int i = 0; i < tabuleiro.GetLength(0); i++)
                                        {
                                            for (int j = 0; j < tabuleiro.GetLength(1); j++)
                                            {
                                                if (tabuleiro[i, j].Location == pecaOrigemLocalizacao)
                                                {
                                                    tabuleiro[i, j].BackColor = CorTransparente;
                                                    tabuleiro[i, j].Image = null;
                                                    tabuleiro[i, j].setcolourBlack(null);
                                                    tabuleiro[i, j].setpieceName(null);
                                                }
                                            }
                                        }
                                        firstPieceClicked = false;
                                        player1Turn = false;
                                    }
                                    else
                                    {
                                        for (int i = 0; i < tabuleiro.GetLength(0); i++)
                                        {
                                            for (int j = 0; j < tabuleiro.GetLength(1); j++)
                                            {
                                                if (tabuleiro[i, j].Location == pecaOrigemLocalizacao)
                                                {
                                                    tabuleiro[i, j].BackColor = CorTransparente;
                                                }
                                            }
                                        }
                                        firstPieceClicked = false;
                                    }
                                }
                                if (player1Turn == true)
                                {
                                    // Torre
                                    if (origemPeca.getpieceName() == "Torre")
                                    {
                                        origemPeca = new Torre();
                                        PodeMover = origemPeca.Mover(tabuleiro, pecaOrigemLocalizacao, destinoPeca.Location, player1Turn);

                                        if (PodeMover)
                                        {
                                            destinoPeca.setpieceName("Torre");
                                            destinoPeca.setcolourBlack(true);
                                            destinoPeca.Image = pecaOrigemImage;
                                            sender = destinoPeca;

                                            for (int i = 0; i < tabuleiro.GetLength(0); i++)
                                            {
                                                for (int j = 0; j < tabuleiro.GetLength(1); j++)
                                                {
                                                    if (tabuleiro[i, j].Location == pecaOrigemLocalizacao)
                                                    {
                                                        tabuleiro[i, j].BackColor = CorTransparente;
                                                        tabuleiro[i, j].Image = null;
                                                        tabuleiro[i, j].setcolourBlack(null);
                                                        tabuleiro[i, j].setpieceName(null);
                                                    }
                                                }
                                            }
                                            firstPieceClicked = false;
                                            player1Turn = false;
                                        }
                                        else
                                        {
                                            for (int i = 0; i < tabuleiro.GetLength(0); i++)
                                            {
                                                for (int j = 0; j < tabuleiro.GetLength(1); j++)
                                                {
                                                    if (tabuleiro[i, j].Location == pecaOrigemLocalizacao)
                                                    {
                                                        tabuleiro[i, j].BackColor = CorTransparente;
                                                    }
                                                }
                                            }
                                            firstPieceClicked = false;
                                        }
                                    }
                                    if (player1Turn == true)
                                    {
                                        // Rei
                                        if (origemPeca.getpieceName() == "Rei")
                                        {
                                            origemPeca = new Rei();
                                            PodeMover = origemPeca.Mover(tabuleiro, pecaOrigemLocalizacao, destinoPeca.Location, player1Turn);

                                            if (PodeMover)
                                            {
                                                destinoPeca.setpieceName("Rei");
                                                destinoPeca.setcolourBlack(true);
                                                destinoPeca.Image = pecaOrigemImage;
                                                sender = destinoPeca;

                                                for (int i = 0; i < tabuleiro.GetLength(0); i++)
                                                {
                                                    for (int j = 0; j < tabuleiro.GetLength(1); j++)
                                                    {
                                                        if (tabuleiro[i, j].Location == pecaOrigemLocalizacao)
                                                        {
                                                            tabuleiro[i, j].BackColor = CorTransparente;
                                                            tabuleiro[i, j].Image = null;
                                                            tabuleiro[i, j].setcolourBlack(null);
                                                            tabuleiro[i, j].setpieceName(null);
                                                        }
                                                    }
                                                }
                                                firstPieceClicked = false;
                                                player1Turn = false;
                                            }
                                            else
                                            {
                                                for (int i = 0; i < tabuleiro.GetLength(0); i++)
                                                {
                                                    for (int j = 0; j < tabuleiro.GetLength(1); j++)
                                                    {
                                                        if (tabuleiro[i, j].Location == pecaOrigemLocalizacao)
                                                        {
                                                            tabuleiro[i, j].BackColor = CorTransparente;
                                                        }
                                                    }
                                                }
                                                firstPieceClicked = false;
                                            }
                                        }
                                    }
                                    if (player1Turn == true)
                                    {
                                        // Rainha
                                        if (origemPeca.getpieceName() == "Rainha")
                                        {
                                            origemPeca = new Rainha();
                                            PodeMover = origemPeca.Mover(tabuleiro, pecaOrigemLocalizacao, destinoPeca.Location, player1Turn);

                                            if (PodeMover)
                                            {
                                                destinoPeca.setpieceName("Rainha");
                                                destinoPeca.setcolourBlack(true);
                                                destinoPeca.Image = pecaOrigemImage;
                                                sender = destinoPeca;

                                                for (int i = 0; i < tabuleiro.GetLength(0); i++)
                                                {
                                                    for (int j = 0; j < tabuleiro.GetLength(1); j++)
                                                    {
                                                        if (tabuleiro[i, j].Location == pecaOrigemLocalizacao)
                                                        {
                                                            tabuleiro[i, j].BackColor = CorTransparente;
                                                            tabuleiro[i, j].Image = null;
                                                            tabuleiro[i, j].setcolourBlack(null);
                                                            tabuleiro[i, j].setpieceName(null);
                                                        }
                                                    }
                                                }
                                                firstPieceClicked = false;
                                                player1Turn = false;
                                            }
                                            else
                                            {
                                                for (int i = 0; i < tabuleiro.GetLength(0); i++)
                                                {
                                                    for (int j = 0; j < tabuleiro.GetLength(1); j++)
                                                    {
                                                        if (tabuleiro[i, j].Location == pecaOrigemLocalizacao)
                                                        {
                                                            tabuleiro[i, j].BackColor = CorTransparente;
                                                        }
                                                    }
                                                }
                                                firstPieceClicked = false;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        else if (destinoPeca.getcolourBlack() == false)
                        {
                            origemPeca.Comer(tabuleiro, pecaOrigemLocalizacao, destinoPeca.Location, player1Turn);
                        }
                    }
                }
            }
            else
            {
                if (player1Turn == false)
                {
                    if (firstPieceClicked == false)
                    {
                        origemPeca = (Peca)sender;
                        if (origemPeca.getcolourBlack() == false)
                        {
                            pecaOrigemLocalizacao = origemPeca.Location;
                            pecaOrigemImage = origemPeca.Image;
                            CorTransparente = origemPeca.BackColor;
                            origemPeca.BackColor = Color.Green;
                            sender = origemPeca;
                            firstPieceClicked = true;
                        }
                    }
                    else
                    {
                        if (player1Turn == false)
                        {
                            destinoPeca = (Peca)sender;

                            if (destinoPeca.getcolourBlack() == null || true)
                            {
                                if (origemPeca.getpieceName() == "Peão")
                                {
                                    origemPeca = new Peao();
                                    PodeMover = origemPeca.Mover(tabuleiro, pecaOrigemLocalizacao, destinoPeca.Location, player1Turn);
                                    podeComer = origemPeca.Comer(tabuleiro, pecaOrigemLocalizacao, destinoPeca.Location, player1Turn);

                                    if (destinoPeca.getcolourBlack() == null && PodeMover == true)
                                    {
                                        destinoPeca.setpieceName("Peão");
                                        destinoPeca.setcolourBlack(false);
                                        destinoPeca.Image = pecaOrigemImage;
                                        sender = destinoPeca;

                                        for (int i = 0; i < tabuleiro.GetLength(0); i++)
                                        {
                                            for (int j = 0; j < tabuleiro.GetLength(1); j++)
                                            {
                                                if (tabuleiro[i, j].Location == pecaOrigemLocalizacao)
                                                {
                                                    tabuleiro[i, j].BackColor = CorTransparente;
                                                    tabuleiro[i, j].Image = null;
                                                    tabuleiro[i, j].setcolourBlack(null);
                                                    tabuleiro[i, j].setpieceName(null);
                                                }
                                            }
                                        }
                                        firstPieceClicked = false;
                                        player1Turn = true;
                                    }
                                    else if (destinoPeca.getcolourBlack() == true && PodeMover == true)
                                    {
                                        destinoPeca.setpieceName("Peão");
                                        destinoPeca.setcolourBlack(false);
                                        destinoPeca.Image = pecaOrigemImage;
                                        sender = destinoPeca;

                                        for (int i = 0; i < tabuleiro.GetLength(0); i++)
                                        {
                                            for (int j = 0; j < tabuleiro.GetLength(1); j++)
                                            {
                                                if (tabuleiro[i, j].Location == destinoPeca.Location)
                                                {
                                                    tabuleiro[i, j].BackColor = CorTransparente;
                                                    tabuleiro[i, j].Image = null;
                                                    tabuleiro[i, j].setcolourBlack(null);
                                                    tabuleiro[i, j].setpieceName(null);
                                                }
                                            }
                                        }
                                        firstPieceClicked = false;
                                        player1Turn = true;
                                    }
                                    else 
                                    {
                                        for (int i = 0; i < tabuleiro.GetLength(0); i++)
                                        {
                                            for (int j = 0; j < tabuleiro.GetLength(1); j++)
                                            {
                                                if (tabuleiro[i, j].Location == pecaOrigemLocalizacao)
                                                {
                                                    tabuleiro[i, j].BackColor = CorTransparente;
                                                }
                                            }
                                        }
                                        firstPieceClicked = false;
                                    }
                                }

                                if (player1Turn == false)
                                {
                                    // Knight
                                    if (origemPeca.getpieceName() == "Cavalo")
                                    {
                                        origemPeca = new Cavalo();
                                        PodeMover = origemPeca.Mover(tabuleiro, pecaOrigemLocalizacao, destinoPeca.Location, player1Turn);

                                        if (PodeMover)
                                        {
                                            destinoPeca.setpieceName("Cavalo");
                                            destinoPeca.setcolourBlack(false);
                                            destinoPeca.Image = pecaOrigemImage;
                                            sender = destinoPeca;

                                            for (int i = 0; i < tabuleiro.GetLength(0); i++)
                                            {
                                                for (int j = 0; j < tabuleiro.GetLength(1); j++)
                                                {
                                                    if (tabuleiro[i, j].Location == pecaOrigemLocalizacao)
                                                    {
                                                        tabuleiro[i, j].BackColor = CorTransparente;
                                                        tabuleiro[i, j].Image = null;
                                                        tabuleiro[i, j].setcolourBlack(null);
                                                        tabuleiro[i, j].setpieceName(null);
                                                    }
                                                }
                                            }
                                            firstPieceClicked = false;
                                            player1Turn = true;
                                        }
                                        else
                                        {
                                            for (int i = 0; i < tabuleiro.GetLength(0); i++)
                                            {
                                                for (int j = 0; j < tabuleiro.GetLength(1); j++)
                                                {
                                                    if (tabuleiro[i, j].Location == pecaOrigemLocalizacao)
                                                    {
                                                        tabuleiro[i, j].BackColor = CorTransparente;
                                                    }
                                                }
                                            }
                                            firstPieceClicked = false;
                                        }
                                    }
                                }
                                if (player1Turn == false)
                                {
                                    // Bispo
                                    if (origemPeca.getpieceName() == "Bispo")
                                    {
                                        origemPeca = new Bispo();
                                        PodeMover = origemPeca.Mover(tabuleiro, pecaOrigemLocalizacao, destinoPeca.Location, player1Turn);

                                        if (PodeMover)
                                        {
                                            destinoPeca.setpieceName("Bispo");
                                            destinoPeca.setcolourBlack(false);
                                            destinoPeca.Image = pecaOrigemImage;
                                            sender = destinoPeca;

                                            for (int i = 0; i < tabuleiro.GetLength(0); i++)
                                            {
                                                for (int j = 0; j < tabuleiro.GetLength(1); j++)
                                                {
                                                    if (tabuleiro[i, j].Location == pecaOrigemLocalizacao)
                                                    {
                                                        tabuleiro[i, j].BackColor = CorTransparente;
                                                        tabuleiro[i, j].Image = null;
                                                        tabuleiro[i, j].setcolourBlack(null);
                                                        tabuleiro[i, j].setpieceName(null);
                                                    }
                                                }
                                            }
                                            firstPieceClicked = false;
                                            player1Turn = true;
                                        }
                                        else
                                        {
                                            for (int i = 0; i < tabuleiro.GetLength(0); i++)
                                            {
                                                for (int j = 0; j < tabuleiro.GetLength(1); j++)
                                                {
                                                    if (tabuleiro[i, j].Location == pecaOrigemLocalizacao)
                                                    {
                                                        tabuleiro[i, j].BackColor = CorTransparente;
                                                    }
                                                }
                                            }
                                            firstPieceClicked = false;
                                        }
                                    }
                                }
                                if (player1Turn == false)
                                {
                                    // Torre
                                    if (origemPeca.getpieceName() == "Torre")
                                    {
                                        origemPeca = new Torre();
                                        PodeMover = origemPeca.Mover(tabuleiro, pecaOrigemLocalizacao, destinoPeca.Location, player1Turn);

                                        if (PodeMover)
                                        {
                                            destinoPeca.setpieceName("Torre");
                                            destinoPeca.setcolourBlack(false);
                                            destinoPeca.Image = pecaOrigemImage;
                                            sender = destinoPeca;

                                            for (int i = 0; i < tabuleiro.GetLength(0); i++)
                                            {
                                                for (int j = 0; j < tabuleiro.GetLength(1); j++)
                                                {
                                                    if (tabuleiro[i, j].Location == pecaOrigemLocalizacao)
                                                    {
                                                        tabuleiro[i, j].BackColor = CorTransparente;
                                                        tabuleiro[i, j].Image = null;
                                                        tabuleiro[i, j].setcolourBlack(null);
                                                        tabuleiro[i, j].setpieceName(null);
                                                    }
                                                }
                                            }
                                            firstPieceClicked = false;
                                            player1Turn = true;
                                        }
                                        else
                                        {
                                            for (int i = 0; i < tabuleiro.GetLength(0); i++)
                                            {
                                                for (int j = 0; j < tabuleiro.GetLength(1); j++)
                                                {
                                                    if (tabuleiro[i, j].Location == pecaOrigemLocalizacao)
                                                    {
                                                        tabuleiro[i, j].BackColor = CorTransparente;
                                                    }
                                                }
                                            }
                                            firstPieceClicked = false;
                                        }
                                    }
                                }
                                if (player1Turn == false)
                                {
                                    // Rei
                                    if (origemPeca.getpieceName() == "Rei")
                                    {
                                        origemPeca = new Rei();
                                        PodeMover = origemPeca.Mover(tabuleiro, pecaOrigemLocalizacao, destinoPeca.Location, player1Turn);

                                        if (PodeMover)
                                        {
                                            destinoPeca.setpieceName("Rei");
                                            destinoPeca.setcolourBlack(false);
                                            destinoPeca.Image = pecaOrigemImage;
                                            sender = destinoPeca;

                                            for (int i = 0; i < tabuleiro.GetLength(0); i++)
                                            {
                                                for (int j = 0; j < tabuleiro.GetLength(1); j++)
                                                {
                                                    if (tabuleiro[i, j].Location == pecaOrigemLocalizacao)
                                                    {
                                                        tabuleiro[i, j].BackColor = CorTransparente;
                                                        tabuleiro[i, j].Image = null;
                                                        tabuleiro[i, j].setcolourBlack(null);
                                                        tabuleiro[i, j].setpieceName(null);
                                                    }
                                                }
                                            }
                                            firstPieceClicked = false;
                                            player1Turn = true;
                                        }
                                        else
                                        {
                                            for (int i = 0; i < tabuleiro.GetLength(0); i++)
                                            {
                                                for (int j = 0; j < tabuleiro.GetLength(1); j++)
                                                {
                                                    if (tabuleiro[i, j].Location == pecaOrigemLocalizacao)
                                                    {
                                                        tabuleiro[i, j].BackColor = CorTransparente;
                                                    }
                                                }
                                            }
                                            firstPieceClicked = false;
                                        }
                                    }
                                }
                                if (player1Turn == false)
                                {
                                    // Rainha
                                    if (origemPeca.getpieceName() == "Rainha")
                                    {
                                        origemPeca = new Rainha();
                                        PodeMover = origemPeca.Mover(tabuleiro, pecaOrigemLocalizacao, destinoPeca.Location, player1Turn);

                                        if (PodeMover)
                                        {
                                            destinoPeca.setpieceName("Rainha");
                                            destinoPeca.setcolourBlack(false);
                                            destinoPeca.Image = pecaOrigemImage;
                                            sender = destinoPeca;

                                            for (int i = 0; i < tabuleiro.GetLength(0); i++)
                                            {
                                                for (int j = 0; j < tabuleiro.GetLength(1); j++)
                                                {
                                                    if (tabuleiro[i, j].Location == pecaOrigemLocalizacao)
                                                    {
                                                        tabuleiro[i, j].BackColor = CorTransparente;
                                                        tabuleiro[i, j].Image = null;
                                                        tabuleiro[i, j].setcolourBlack(null);
                                                        tabuleiro[i, j].setpieceName(null);
                                                    }
                                                }
                                            }
                                            firstPieceClicked = false;
                                            player1Turn = true;
                                        }
                                        else
                                        {
                                            for (int i = 0; i < tabuleiro.GetLength(0); i++)
                                            {
                                                for (int j = 0; j < tabuleiro.GetLength(1); j++)
                                                {
                                                    if (tabuleiro[i, j].Location == pecaOrigemLocalizacao)
                                                    {
                                                        tabuleiro[i, j].BackColor = CorTransparente;
                                                    }
                                                }
                                            }
                                            firstPieceClicked = false;
                                        }
                                    }
                                }
                            }
                            else if (destinoPeca.getcolourBlack() == false)
                            {
                                origemPeca.Comer(tabuleiro, pecaOrigemLocalizacao, destinoPeca.Location, player1Turn);
                            }
                        }
                    }
                }
            }
        }
    }
}