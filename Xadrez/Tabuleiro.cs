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

        Peca[,] tabuleiro = new Peca[8, 8];                            // Array duplo do tipo peca 8 por 8
        Peca[,] BlackPiecesPosition = new Peca[4, 4];                  // Array duplo do tipo peca 4 por 4 para a posição inicial das peças pretas
        Peca[,] WhitePiecesPosition = new Peca[4, 4];                  // Array duplo do tipo peca 4 por 4, para a posição inicial das peças brancas
        Size pictureBoxSize = new Size(70, 70);                        // Tamanho das pictureboxs 
        int coordenadaX = 10;                                          // Localização inicial das pictureBoxes do tabuleiro no X
        int coordenadaY = 0;                                           // Localização inicial das pictureBoxes do tabuleiro no Y

        Peca origemPeca;                                               // Peça clickada
        Peca destinoPeca;                                              // Destino da peça clickada
        Point pecaOrigemLocalizacao;                                   // Localização da peça clickada
        Image pecaOrigemImage;                                         // Imagem da peça clickada
        Image pecaDestinoImage;                                        // Imagem da casa para onde a peça clickada se move
        Color CorTransparente;                                         // Backgroundcolor transparente

        bool PodeMover;                                                // Boolean que checka se pode mover a peça ou não
        bool firstPieceClicked = false;                                // Boolean que checka se a peça foi clickada pela primeira vez
        bool player1Turn = true;                                       // Boolean que checka se é a vez do jogador 1 ou do jogador 2
        bool podeComer;                                                // Boolean que checka se a peça pode comer ou não
        bool Comeu;                                                    // Checka se a peça comeu

        int contadorBrancoI = 0;                                       // int para a animação das peças brancas
        int contadorBrancoJ = 0;                                       // int para a animação das peças brancas
        int contadorTabuleiroBrancoI = 7;                              // int para a animação das peças brancas
        int contadorTabuleiroBrancoJ = 0;                              // int para a animação das peças brancas

        int contadorPretoI = 0;                                        // int para a animação das peças pretas          
        int contadorPretoJ = 0;                                        // int para a animação das peças pretas
        int contadorTabuleiroPretoI = 0;                               // int para a animação das peças pretas
        int contadorTabuleiroPretoJ = 0;                               // int para a animação das peças pretas

        /// <summary>
        /// Inicialização dos componentes da form tabuleiro
        /// </summary>
        public Tabuleiro()
        {
            InitializeComponent();      // Inicializa os componentes da form                                         
        }

        /// <summary>
        /// Desenha o tabuleiro com todas as peças 
        /// </summary>
        /// <param name="sender"> Recebe as PicturesBoxes </param>
        /// <param name="e"> Recebe o Evento a ser realizado </param>
        private void Tabuleiro_Load(object sender, EventArgs e)
        {
            desenhaTabuleiro();             // Desenha o tabuleiro
            BlackPiecesStartLocation();     // Chama o método que faz com que as peças começem fora do tabuleiro
            WhitePiecesStartLocation();     // Chama o método que faz com que as peças começem fora do tabuleiro
            timerBlackPieces.Start();       // Timer que faz a animação das peças Pretas   
            timerWhitePieces.Start();       // Timer que faz a animação das peças Brancas
        }

        /// <summary>
        /// Fecha o tabuleiro e abre o Menu
        /// </summary>
        /// <param name="sender"> Recebe a Label </param>
        /// <param name="e"> Executa o Evento </param>
        private void labelExit_Click(object sender, EventArgs e)
        {
            FormMenu formMenu = new FormMenu();                 // Cria o Menu dentro da form Tabuleiro
            formMenu.Show();                                    // Abre o Menu
            this.Close();                                       // Fecha a form Tabuleiro
        }

        /// <summary>
        /// Minimiza a Form
        /// </summary>
        /// <param name="sender"> Recebe a Label </param>
        /// <param name="e"> Executa o evento </param>
        private void labelMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;       // Minimiza a Form               
        }

        /// <summary>
        /// Desenha o Tabuleiro
        /// </summary>
        public void desenhaTabuleiro()
        {
            // Ciclo for para as colunas do tabuleiro
            for (int i = 0; i < tabuleiro.GetLength(0); i++)
            {
                // Ciclo for para as linhas do tabuleiro
                for (int j = 0; j < tabuleiro.GetLength(1); j++)
                {

                    tabuleiro[i, j] = new Peca();                   // Cria uma nova Peca em todas coordenada do tabuleiro
                    tabuleiro[i, j].setcolourBlack(null);           // Da o valor de null à cor dessas peças
                    tabuleiro[i, j].Size = pictureBoxSize;          // Dá o size de 70 por 70 a cada PictureBox               
                    tabuleiro[i, j].Click += pieceClick;            // Executa o método que permite as peças se moverem 

                    // Se o valor i (colunas) for igual a 0 
                    if (i == 0)
                    {
                        // Se o valor j (linhas) for igual a 0 ou 7
                        if (j == 0 || j == 7)
                        {
                            tabuleiro[i, j] = new Torre("Torre", true);                          // Cria uma Peca do tipo Torre                          
                            tabuleiro[i, j].Size = pictureBoxSize;                               // Dá à PictureBox o size 70 por 70
                            tabuleiro[i, j].Click += pieceClick;                                 // Executa o método que permite as peças se moverem 
                        }

                        // Se o valor j (linhas) for igual a 1 ou 6
                        if (j == 1 || j == 6)
                        {
                            tabuleiro[i, j] = new Cavalo("Cavalo", true);                        // Cria uma Peca do tipo Cavalo                         
                            tabuleiro[i, j].Size = pictureBoxSize;                               // Dá à PictureBox o size 70 por 70
                            tabuleiro[i, j].Click += pieceClick;                                 // Executa o método que permite as peças se moverem 
                        }

                        // Se o valor j (linhas) for igual a 2 ou 5
                        if (j == 2 || j == 5)
                        {
                            tabuleiro[i, j] = new Bispo("Bispo", true);                          // Cria uma Peca do tipo Bispo                
                            tabuleiro[i, j].Size = pictureBoxSize;                               // Dá à PictureBox o size 70 por 70
                            tabuleiro[i, j].Click += pieceClick;                                 // Executa o método que permite as peças se moverem 
                        }

                        // Se o valor j (linhas) for igual a 3
                        if (j == 3)
                        {
                            tabuleiro[i, j] = new Rainha("Rainha", true);                        // Cria uma Peca do tipo Rainha                        
                            tabuleiro[i, j].Size = pictureBoxSize;                               // Dá à PictureBox o size 70 por 70
                            tabuleiro[i, j].Click += pieceClick;                                 // Executa o método que permite as peças se moverem 
                        }

                        // Se o valor j (linhas) for igual a 4
                        if (j == 4)
                        {
                            tabuleiro[i, j] = new Rei("Rei", true);                              // Cria uma Peca do tipo Rei                      
                            tabuleiro[i, j].Size = pictureBoxSize;                               // Dá à PictureBox o size 70 por 70
                            tabuleiro[i, j].Click += pieceClick;                                 // Executa o método que permite as peças se moverem 
                        }
                    }

                    // Se o valor i (colunas) for igual a 1
                    if (i == 1)
                    {
                        tabuleiro[i, j] = new Peao("Peão", true);                                // Cria uma Peca do tipo Peão                  
                        tabuleiro[i, j].Size = pictureBoxSize;                                   // Dá à PictureBox o size 70 por 70
                        tabuleiro[i, j].Click += pieceClick;                                     // Executa o método que permite as peças se moverem 
                    }

                    // Se o valor i (colunas) for igual a 6
                    if (i == 6)
                    {
                        tabuleiro[i, j] = new Peao("Peão", false);                               // Cria uma Peca do tipo Peão           
                        tabuleiro[i, j].Size = pictureBoxSize;                                   // Dá à PictureBox o size 70 por 70
                        tabuleiro[i, j].Click += pieceClick;                                     // Executa o método que permite as peças se moverem 
                    }

                    // Se o valor i (colunas) for igual a 7
                    if (i == 7)
                    {
                        // Se o valor j (linhas) for igual a 0 ou 7
                        if (j == 0 || j == 7)
                        {
                            tabuleiro[i, j] = new Torre("Torre", false);                         // Cria uma Peca do tipo Torre                       
                            tabuleiro[i, j].Size = pictureBoxSize;                               // Dá à PictureBox o size 70 por 70
                            tabuleiro[i, j].Click += pieceClick;                                 // Executa o método que permite as peças se moverem 
                        }

                        // Se o valor j (linhas) for igual a 1 ou 6
                        if (j == 1 || j == 6)
                        {
                            tabuleiro[i, j] = new Cavalo("Cavalo", false);                       // Cria uma Peca do tipo Cavalo                     
                            tabuleiro[i, j].Size = pictureBoxSize;                               // Dá à PictureBox o size 70 por 70
                            tabuleiro[i, j].Click += pieceClick;                                 // Executa o método que permite as peças se moverem 

                        }

                        // Se o valor j (linhas) for igual a 2 ou 5
                        if (j == 2 || j == 5)
                        {
                            tabuleiro[i, j] = new Bispo("Bispo", false);                          // Cria uma Peca do tipo Bispo
                            tabuleiro[i, j].Size = pictureBoxSize;                                // Dá à PictureBox o size 70 por 70
                            tabuleiro[i, j].Click += pieceClick;                                  // Executa o método que permite as peças se moverem 
                        }

                        // Se o valor j (linhas) for igual a 3
                        if (j == 3)
                        {
                            tabuleiro[i, j] = new Rainha("Rainha", false);                        // Cria uma Peca do tipo Rainha                          
                            tabuleiro[i, j].Size = pictureBoxSize;                                // Dá à PictureBox o size 70 por 70
                            tabuleiro[i, j].Click += pieceClick;                                  // Executa o método que permite as peças se moverem 
                        }

                        // Se o valor j (linhas) for igual a 4
                        if (j == 4)
                        {
                            tabuleiro[i, j] = new Rei("Rei", false);                              // Cria uma Peca do tipo Rei
                            tabuleiro[i, j].Size = pictureBoxSize;                                // Dá à PictureBox o size 70 por 70
                            tabuleiro[i, j].Click += pieceClick;                                  // Executa o método que permite as peças se moverem 
                        }
                    }

                    // Verifica se o valor de i (colunas) é par
                    if (i % 2 == 0)
                    {
                        //Verifica se o valor de j (linhas) é par
                        if (j % 2 == 0)
                        {
                            tabuleiro[i, j].BackColor = Color.DarkRed;      // Se ambas forem par o backgroundcolor fica vermelho      
                        }
                        else
                        {
                            tabuleiro[i, j].BackColor = Color.LightGray;    // Se não, o backgroundcolor fica vermelho      
                        }
                    }
                    else
                    {
                        // Verifica se o valor de j (linhas) é par
                        if (j % 2 == 0)
                        {
                            tabuleiro[i, j].BackColor = Color.LightGray;    // Se i for impar e j par, o backgroundcolor fica vermelho   
                        }
                        else
                        {
                            tabuleiro[i, j].BackColor = Color.DarkRed;      // Se não, o backgroundcolor fica vermelho   
                        }
                    }

                    tabuleiro[i, j].Size = pictureBoxSize;                               // Dá à PictureBox o size 70 por 70
                    tabuleiro[i, j].SizeMode = PictureBoxSizeMode.CenterImage;           //Define o modo de apresentação da imagem de cada PictureBox
                    tabuleiro[i, j].Location = new Point(coordenadaX, coordenadaY);      // Dá o valor da localização à PictureBox
                    panelFill.Controls.Add(tabuleiro[i, j]);
                    coordenadaX += 70;                                                   // Incrementa o valor do X na localização                   
                }
                coordenadaX = 10;             // Reseta o valor de X
                coordenadaY += 70;            // Incrementa o valor de Y
            }
        }

        /// <summary>
        /// Inicializa as peças pretas na sua posição inicial
        /// </summary>
        public void BlackPiecesStartLocation()
        {
            int positionX = 10;                                         // Posição inicial
            int positionY = 0;                                          // Posição inicial

            // Verifica se o valor de i (colunas)
            for (int i = 0; i < BlackPiecesPosition.GetLength(0); i++)
            {
                // Verifica se o valor de j (linhas)
                for (int j = 0; j < BlackPiecesPosition.GetLength(1); j++)
                {
                    BlackPiecesPosition[i, j] = new Peca();                                    
                    BlackPiecesPosition[i, j].Location = new Point(positionX, positionY);       
                    BlackPiecesPosition[i, j].Size = pictureBoxSize;

                    if (i > 1)
                    {
                        BlackPiecesPosition[i, j].Image = Xadrez.Properties.Resources.BlackPawn;
                        BlackPiecesPosition[i, j].BackColor = Color.Transparent;
                    }
                    else
                    {
                        if (i == 0)
                        {
                            if (j == 0)
                            {
                                BlackPiecesPosition[i, j].Image = Xadrez.Properties.Resources.BlackRook;
                                BlackPiecesPosition[i, j].BackColor = Color.Transparent;
                            }

                            if (j == 1)
                            {
                                BlackPiecesPosition[i, j].Image = Xadrez.Properties.Resources.BlackKnight;
                                BlackPiecesPosition[i, j].BackColor = Color.Transparent;
                            }

                            if (j == 2)
                            {
                                BlackPiecesPosition[i, j].Image = Xadrez.Properties.Resources.BlackBishop;
                                BlackPiecesPosition[i, j].BackColor = Color.Transparent;
                            }

                            if (j == 3)
                            {
                                BlackPiecesPosition[i, j].Image = Xadrez.Properties.Resources.BlackQueen;
                                BlackPiecesPosition[i, j].BackColor = Color.Transparent;
                            }
                        }
                        else
                        {
                            if (j == 0)
                            {
                                BlackPiecesPosition[i, j].Image = Xadrez.Properties.Resources.BlackKing;
                                BlackPiecesPosition[i, j].BackColor = Color.Transparent;
                            }

                            if (j == 1)
                            {
                                BlackPiecesPosition[i, j].Image = Xadrez.Properties.Resources.BlackBishop;
                                BlackPiecesPosition[i, j].BackColor = Color.Transparent;
                            }

                            if (j == 2)
                            {
                                BlackPiecesPosition[i, j].Image = Xadrez.Properties.Resources.BlackKnight;
                                BlackPiecesPosition[i, j].BackColor = Color.Transparent;
                            }

                            if (j == 3)
                            {
                                BlackPiecesPosition[i, j].Image = Xadrez.Properties.Resources.BlackRook;
                                BlackPiecesPosition[i, j].BackColor = Color.Transparent;
                            }
                        }
                    }
                    BlackPiecesPosition[i, j].SizeMode = PictureBoxSizeMode.CenterImage;
                    panelPlayer1.Controls.Add(BlackPiecesPosition[i, j]);
                    positionX += 70;
                }
                positionX = 10;
                positionY += 70;
            }
        }

        /// <summary>
        /// Inicializa as peças brancas nas suas posições iniciais
        /// </summary>
        public void WhitePiecesStartLocation()
        {
            int positionX = 10;     //Inicializa o X inicial das peças do lado branco que irá ser do lado direito do tabuleiro
            int positionY = 0;    //Inicializa o Y inicial das peças do lado branco que irá ser do lado direito do tabuleiro

            //ciclo for duplo para controlar o array das peças brancas
            for (int i = 0; i < WhitePiecesPosition.GetLength(0); i++)
            {
                for (int j = 0; j < WhitePiecesPosition.GetLength(1); j++)
                {
                    WhitePiecesPosition[i, j] = new Peca();                                  //Inicializa cada posição do array
                    WhitePiecesPosition[i, j].Location = new Point(positionX, positionY);    //Define a localização à PictureBox
                    WhitePiecesPosition[i, j].Size = pictureBoxSize;                         //Define o tamanho das PictureBox já previamente definido

                    //Verifica se o i é maior que 1
                    if (i > 1)
                    {
                        WhitePiecesPosition[i, j].Image = Xadrez.Properties.Resources.WhitePawn;
                        WhitePiecesPosition[i, j].BackColor = Color.Transparent;

                    }
                    else
                    {
                        //Verifica se o i é igual a 0
                        if (i == 0)
                        {
                            //Verifica se o j é igual a 0
                            if (j == 0)
                            {
                                WhitePiecesPosition[i, j].Image = Xadrez.Properties.Resources.WhiteRook;
                                WhitePiecesPosition[i, j].BackColor = Color.Transparent;
                            }

                            //Verifica se o j é igual a 1
                            if (j == 1)
                            {
                                WhitePiecesPosition[i, j].Image = Xadrez.Properties.Resources.WhiteKnight;
                                WhitePiecesPosition[i, j].BackColor = Color.Transparent;
                            }

                            //Verifica se o j é igual a 2
                            if (j == 2)
                            {
                                WhitePiecesPosition[i, j].Image = Xadrez.Properties.Resources.WhiteBishop;
                                WhitePiecesPosition[i, j].BackColor = Color.Transparent;
                            }

                            //Verifica se o j é igual a 3
                            if (j == 3)
                            {
                                WhitePiecesPosition[i, j].Image = Xadrez.Properties.Resources.WhiteQueen;
                                WhitePiecesPosition[i, j].BackColor = Color.Transparent;
                            }
                        }
                        else
                        {
                            //Verifica se o j é igual a 0
                            if (j == 0)
                            {
                                WhitePiecesPosition[i, j].Image = Xadrez.Properties.Resources.WhiteKing;
                                WhitePiecesPosition[i, j].BackColor = Color.Transparent;
                            }

                            //Verifica se o j é igual a 1
                            if (j == 1)
                            {
                                WhitePiecesPosition[i, j].Image = Xadrez.Properties.Resources.WhiteBishop;
                                WhitePiecesPosition[i, j].BackColor = Color.Transparent;
                            }

                            //Verifica se o j é igual a 2
                            if (j == 2)
                            {
                                WhitePiecesPosition[i, j].Image = Xadrez.Properties.Resources.WhiteKnight;
                                WhitePiecesPosition[i, j].BackColor = Color.Transparent;
                            }

                            //Verifica se o j é igual a 3
                            if (j == 3)
                            {
                                WhitePiecesPosition[i, j].Image = Xadrez.Properties.Resources.WhiteRook;
                                WhitePiecesPosition[i, j].BackColor = Color.Transparent;
                            }
                        }
                    }
                    WhitePiecesPosition[i, j].SizeMode = PictureBoxSizeMode.CenterImage;    //Define o modo de apresentação da imagem de cada PictureBox
                    panelPlayer2.Controls.Add(WhitePiecesPosition[i, j]);                      //Adiciona as pictureBox ao panelRight(painel da direita)
                    positionX += 70;    //Incrementa o valor do x
                }
                positionX = 10;         //Faz reset ao valor de X
                positionY += 70;        //Incrementa o valor de Y
            }
        }

        /// <summary>
        /// Método click que permite que as peças se movam
        /// </summary>
        /// <param name="sender"> Recebe a Peça </param>
        /// <param name="e"> Executa o evento de Mover a Peça </param>
        private void pieceClick(object sender, EventArgs e)
        {
            // Verifica se é o turno do jogador 1
            if (player1Turn == true)
            {
                // Verifica se a peça clickada já foi clickada pelo jogador
                if (firstPieceClicked == false)
                {
                    origemPeca = (Peca)sender;                             // Toma o valor do sender

                    // Se a peça selecionada for preta
                    if (origemPeca.getcolourBlack() == true)
                    {
                        pecaOrigemLocalizacao = origemPeca.Location;       // Toma o valor da localização da Peça selecionada
                        pecaOrigemImage = origemPeca.Image;                // Toma o valor da imagem da Peça selecionada 
                        CorTransparente = origemPeca.BackColor;            // Toma o valor da backcolour da imagem da Peça selecionada
                        origemPeca.BackColor = Color.Green;                // Toma o valor de verde
                        sender = origemPeca;                               // Toma o valor da Peça selecionada
                        firstPieceClicked = true;                          // Toma o valor de true
                    }
                }
                // Se a peça clickada não foi a primeira a ser selecionada
                else
                {
                    // Verifica se é o turno do jogador 1
                    if (player1Turn == true)
                    {
                        destinoPeca = (Peca)sender;                        // Toma o valor do sender

                        // Se a peça selecionada for diferente da cor preta
                        if (destinoPeca.getcolourBlack() != true)
                        {
                            // Se a peça selecionada for um Peão
                            if (origemPeca.getpieceName() == "Peão")
                            {
                                origemPeca = new Peao();            // Toma o valor de um novo Peão

                                PodeMover = origemPeca.Mover(tabuleiro, pecaOrigemLocalizacao, destinoPeca.Location, player1Turn);      // Recebe o método que indica se a Peça pode-se mover ou não
                                podeComer = origemPeca.Comer(tabuleiro, pecaOrigemLocalizacao, destinoPeca.Location, player1Turn);      // Recebe o método que indica se a Peça comer outra Peça ou não                            
                                
                                // Se a peça para onde o jogador se quer mover for null e se o bool PodeMover for true
                                if (destinoPeca.getcolourBlack() == null && PodeMover == true)
                                {
                                    destinoPeca.setpieceName("Peão");       // Dá o nome ao destino da Peça
                                    destinoPeca.setcolourBlack(true);       // Dá a cor preta ao destino da Peça
                                    destinoPeca.Image = pecaOrigemImage;    // Toma o valor da imagem da Peça selecionada
                                    sender = destinoPeca;                   // Toma o valor do destino da peça

                                    // Ciclo for para as colunas do tabuleiro
                                    for (int i = 0; i < tabuleiro.GetLength(0); i++)
                                    {
                                        // Ciclo for para as linhas do tabuleiro
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

                                else if (destinoPeca.getcolourBlack() == false && podeComer == true)
                                {
                                    destinoPeca.setpieceName("Peão");
                                    destinoPeca.setcolourBlack(true);
                                    pecaDestinoImage = destinoPeca.Image;   // Toma o valor da imagem da Peça destino
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
                                    for (int i = 0; i < WhitePiecesPosition.GetLength(0); i++)
                                    {                                       
                                        for (int j = 0; j < WhitePiecesPosition.GetLength(1); j++)
                                        {
                                            Comeu = false;
                                            if (WhitePiecesPosition[i, j].Image == null)
                                            {
                                                WhitePiecesPosition[i, j].Image = pecaDestinoImage;
                                                Comeu = true;
                                                break;                                                
                                            }
                                        } 
                                        if (Comeu == true)
                                        {
                                            break;
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
                                if (destinoPeca.Comer(tabuleiro, pecaOrigemLocalizacao, destinoPeca.Location, player1Turn) && destinoPeca.getpieceName() == "Rei")
                                {
                                    destinoPeca.setcheck(true);
                                }
                                else
                                {
                                    destinoPeca.setcheck(true);
                                }
                            }                                
                            if (player1Turn == true)
                            {
                                // Knight
                                if (origemPeca.getpieceName() == "Cavalo")
                                {
                                    origemPeca = new Cavalo();

                                    PodeMover = origemPeca.Mover(tabuleiro, pecaOrigemLocalizacao, destinoPeca.Location, player1Turn);
                                    podeComer = origemPeca.Comer(tabuleiro, pecaOrigemLocalizacao, destinoPeca.Location, player1Turn);

                                    if (destinoPeca.getcolourBlack() == null && PodeMover == true)
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

                                    else if (destinoPeca.getcolourBlack() == false && podeComer == true)
                                    {
                                        destinoPeca.setpieceName("Cavalo");
                                        destinoPeca.setcolourBlack(true);
                                        pecaDestinoImage = destinoPeca.Image;   // Toma o valor da imagem da Peça destino
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
                                        for (int i = 0; i < WhitePiecesPosition.GetLength(0); i++)
                                        {
                                            for (int j = 0; j < WhitePiecesPosition.GetLength(1); j++)
                                            {
                                                Comeu = false;
                                                if (WhitePiecesPosition[i, j].Image == null)
                                                {
                                                    WhitePiecesPosition[i, j].Image = pecaDestinoImage;
                                                    Comeu = true;
                                                    break;
                                                }
                                            }
                                            if (Comeu == true)
                                            {
                                                break;
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
                                    if (destinoPeca.Comer(tabuleiro, pecaOrigemLocalizacao, destinoPeca.Location, player1Turn) && destinoPeca.getpieceName() == "Rei")
                                    {
                                        destinoPeca.setcheck(true);
                                    }
                                    else
                                    {
                                        destinoPeca.setcheck(true);
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
                                    podeComer = origemPeca.Comer(tabuleiro, pecaOrigemLocalizacao, destinoPeca.Location, player1Turn);

                                    if (destinoPeca.getcolourBlack() == null && PodeMover == true)
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

                                    else if (destinoPeca.getcolourBlack() == false && podeComer == true)
                                    {
                                        destinoPeca.setpieceName("Bispo");
                                        destinoPeca.setcolourBlack(true);
                                        pecaDestinoImage = destinoPeca.Image;   // Toma o valor da imagem da Peça destino
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
                                        for (int i = 0; i < WhitePiecesPosition.GetLength(0); i++)
                                        {
                                            for (int j = 0; j < WhitePiecesPosition.GetLength(1); j++)
                                            {
                                                Comeu = false;
                                                if (WhitePiecesPosition[i, j].Image == null)
                                                {
                                                    WhitePiecesPosition[i, j].Image = pecaDestinoImage;
                                                    Comeu = true;
                                                    break;
                                                }
                                            }
                                            if (Comeu == true)
                                            {
                                                break;
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
                                    if (destinoPeca.Comer(tabuleiro, pecaOrigemLocalizacao, destinoPeca.Location, player1Turn) && destinoPeca.getpieceName() == "Rei")
                                    {
                                        destinoPeca.setcheck(true);
                                    }
                                    else
                                    {
                                        destinoPeca.setcheck(true);
                                    }
                                }
                            }
                            if (player1Turn == true)
                            {
                                // Torre
                                if (origemPeca.getpieceName() == "Torre")
                                {
                                    origemPeca = new Torre();

                                    PodeMover = origemPeca.Mover(tabuleiro, pecaOrigemLocalizacao, destinoPeca.Location, player1Turn);
                                    podeComer = origemPeca.Comer(tabuleiro, pecaOrigemLocalizacao, destinoPeca.Location, player1Turn);

                                    if (destinoPeca.getcolourBlack() == null && PodeMover == true)
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

                                    else if (destinoPeca.getcolourBlack() == false && podeComer == true)
                                    {
                                        destinoPeca.setpieceName("Torre");
                                        destinoPeca.setcolourBlack(true);
                                        pecaDestinoImage = destinoPeca.Image;   // Toma o valor da imagem da Peça destino
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
                                        for (int i = 0; i < WhitePiecesPosition.GetLength(0); i++)
                                        {
                                            for (int j = 0; j < WhitePiecesPosition.GetLength(1); j++)
                                            {
                                                Comeu = false;
                                                if (WhitePiecesPosition[i, j].Image == null)
                                                {
                                                    WhitePiecesPosition[i, j].Image = pecaDestinoImage;
                                                    Comeu = true;
                                                    break;
                                                }
                                            }
                                            if (Comeu == true)
                                            {
                                                break;
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
                                    if (destinoPeca.Comer(tabuleiro, pecaOrigemLocalizacao, destinoPeca.Location, player1Turn) && destinoPeca.getpieceName() == "Rei")
                                    {
                                        destinoPeca.setcheck(true);
                                    }
                                    else
                                    {
                                        destinoPeca.setcheck(true);
                                    }
                                }
                            }
                            if (player1Turn == true)
                            {
                                // Rei
                                if (origemPeca.getpieceName() == "Rei")
                                {
                                    origemPeca = new Rei();

                                    PodeMover = origemPeca.Mover(tabuleiro, pecaOrigemLocalizacao, destinoPeca.Location, player1Turn);
                                    podeComer = origemPeca.Comer(tabuleiro, pecaOrigemLocalizacao, destinoPeca.Location, player1Turn);

                                    if (destinoPeca.getcolourBlack() == null && PodeMover == true)
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

                                    else if (destinoPeca.getcolourBlack() == false && podeComer == true)
                                    {
                                        destinoPeca.setpieceName("Rei");
                                        destinoPeca.setcolourBlack(true);
                                        pecaDestinoImage = destinoPeca.Image;   // Toma o valor da imagem da Peça destino
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
                                        for (int i = 0; i < WhitePiecesPosition.GetLength(0); i++)
                                        {
                                            for (int j = 0; j < WhitePiecesPosition.GetLength(1); j++)
                                            {
                                                Comeu = false;
                                                if (WhitePiecesPosition[i, j].Image == null)
                                                {
                                                    WhitePiecesPosition[i, j].Image = pecaDestinoImage;
                                                    Comeu = true;
                                                    break;
                                                }
                                            }
                                            if (Comeu == true)
                                            {
                                                break;
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
                                    if (destinoPeca.Comer(tabuleiro, pecaOrigemLocalizacao, destinoPeca.Location, player1Turn) && destinoPeca.getpieceName() == "Rei")
                                    {
                                        destinoPeca.setcheck(true);
                                    }
                                    else
                                    {
                                        destinoPeca.setcheck(true);
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
                                    podeComer = origemPeca.Comer(tabuleiro, pecaOrigemLocalizacao, destinoPeca.Location, player1Turn);

                                    if (destinoPeca.getcolourBlack() == null && PodeMover == true)
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

                                    else if (destinoPeca.getcolourBlack() == false && podeComer == true)
                                    {
                                        destinoPeca.setpieceName("Rainha");
                                        destinoPeca.setcolourBlack(true);
                                        pecaDestinoImage = destinoPeca.Image;   // Toma o valor da imagem da Peça destino
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
                                        for (int i = 0; i < WhitePiecesPosition.GetLength(0); i++)
                                        {
                                            for (int j = 0; j < WhitePiecesPosition.GetLength(1); j++)
                                            {
                                                Comeu = false;
                                                if (WhitePiecesPosition[i, j].Image == null)
                                                {
                                                    WhitePiecesPosition[i, j].Image = pecaDestinoImage;
                                                    Comeu = true;
                                                    break;
                                                }
                                            }
                                            if (Comeu == true)
                                            {
                                                break;
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
                                    if (destinoPeca.Comer(tabuleiro, pecaOrigemLocalizacao, destinoPeca.Location, player1Turn) && destinoPeca.getpieceName() == "Rei")
                                    {
                                        destinoPeca.setcheck(true);
                                    }
                                    else
                                    {
                                        destinoPeca.setcheck(true);
                                    }
                                }
                            }
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

                            if (destinoPeca.getcolourBlack() != false)
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

                                    else if (destinoPeca.getcolourBlack() == true && podeComer == true)
                                    {
                                        destinoPeca.setpieceName("Peão");
                                        destinoPeca.setcolourBlack(false);
                                        pecaDestinoImage = destinoPeca.Image;   // Toma o valor da imagem da Peça destino
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
                                        for (int i = 0; i < WhitePiecesPosition.GetLength(0); i++)
                                        {
                                            for (int j = 0; j < WhitePiecesPosition.GetLength(1); j++)
                                            {
                                                Comeu = false;
                                                if (WhitePiecesPosition[i, j].Image == null)
                                                {
                                                    WhitePiecesPosition[i, j].Image = pecaDestinoImage;
                                                    Comeu = true;
                                                    break;
                                                }
                                            }
                                            if (Comeu == true)
                                            {
                                                break;
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
                                        podeComer = origemPeca.Comer(tabuleiro, pecaOrigemLocalizacao, destinoPeca.Location, player1Turn);

                                        if (destinoPeca.getcolourBlack() == null && PodeMover == true)
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

                                        else if (destinoPeca.getcolourBlack() == true && podeComer == true)
                                        {
                                            destinoPeca.setpieceName("Cavalo");
                                            destinoPeca.setcolourBlack(false);
                                            pecaDestinoImage = destinoPeca.Image;   // Toma o valor da imagem da Peça destino
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
                                            for (int i = 0; i < WhitePiecesPosition.GetLength(0); i++)
                                            {
                                                for (int j = 0; j < WhitePiecesPosition.GetLength(1); j++)
                                                {
                                                    Comeu = false;
                                                    if (WhitePiecesPosition[i, j].Image == null)
                                                    {
                                                        WhitePiecesPosition[i, j].Image = pecaDestinoImage;
                                                        Comeu = true;
                                                        break;
                                                    }
                                                }
                                                if (Comeu == true)
                                                {
                                                    break;
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
                                        podeComer = origemPeca.Comer(tabuleiro, pecaOrigemLocalizacao, destinoPeca.Location, player1Turn);

                                        if (destinoPeca.getcolourBlack() == null && PodeMover == true)
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

                                        else if (destinoPeca.getcolourBlack() == true && podeComer == true)
                                        {
                                            destinoPeca.setpieceName("Bispo");
                                            destinoPeca.setcolourBlack(false);
                                            pecaDestinoImage = destinoPeca.Image;   // Toma o valor da imagem da Peça destino
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
                                            for (int i = 0; i < WhitePiecesPosition.GetLength(0); i++)
                                            {
                                                for (int j = 0; j < WhitePiecesPosition.GetLength(1); j++)
                                                {
                                                    Comeu = false;
                                                    if (WhitePiecesPosition[i, j].Image == null)
                                                    {
                                                        WhitePiecesPosition[i, j].Image = pecaDestinoImage;
                                                        Comeu = true;
                                                        break;
                                                    }
                                                }
                                                if (Comeu == true)
                                                {
                                                    break;
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
                                        podeComer = origemPeca.Comer(tabuleiro, pecaOrigemLocalizacao, destinoPeca.Location, player1Turn);

                                        if (destinoPeca.getcolourBlack() == null && PodeMover == true)
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

                                        else if (destinoPeca.getcolourBlack() == true && podeComer == true)
                                        {
                                            destinoPeca.setpieceName("Torre");
                                            destinoPeca.setcolourBlack(false);
                                            pecaDestinoImage = destinoPeca.Image;   // Toma o valor da imagem da Peça destino
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
                                            for (int i = 0; i < WhitePiecesPosition.GetLength(0); i++)
                                            {
                                                for (int j = 0; j < WhitePiecesPosition.GetLength(1); j++)
                                                {
                                                    Comeu = false;
                                                    if (WhitePiecesPosition[i, j].Image == null)
                                                    {
                                                        WhitePiecesPosition[i, j].Image = pecaDestinoImage;
                                                        Comeu = true;
                                                        break;
                                                    }
                                                }
                                                if (Comeu == true)
                                                {
                                                    break;
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
                                        podeComer = origemPeca.Comer(tabuleiro, pecaOrigemLocalizacao, destinoPeca.Location, player1Turn);

                                        if (destinoPeca.getcolourBlack() == null && PodeMover == true)
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

                                        else if (destinoPeca.getcolourBlack() == true && podeComer == true)
                                        {
                                            destinoPeca.setpieceName("Rei");
                                            destinoPeca.setcolourBlack(false);
                                            pecaDestinoImage = destinoPeca.Image;   // Toma o valor da imagem da Peça destino
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
                                            for (int i = 0; i < WhitePiecesPosition.GetLength(0); i++)
                                            {
                                                for (int j = 0; j < WhitePiecesPosition.GetLength(1); j++)
                                                {
                                                    Comeu = false;
                                                    if (WhitePiecesPosition[i, j].Image == null)
                                                    {
                                                        WhitePiecesPosition[i, j].Image = pecaDestinoImage;
                                                        Comeu = true;
                                                        break;
                                                    }
                                                }
                                                if (Comeu == true)
                                                {
                                                    break;
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
                                        podeComer = origemPeca.Comer(tabuleiro, pecaOrigemLocalizacao, destinoPeca.Location, player1Turn);

                                        if (destinoPeca.getcolourBlack() == null && PodeMover == true)
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

                                        else if (destinoPeca.getcolourBlack() == true && podeComer == true)
                                        {
                                            destinoPeca.setpieceName("Rainha");
                                            destinoPeca.setcolourBlack(false);
                                            pecaDestinoImage = destinoPeca.Image;   // Toma o valor da imagem da Peça destino
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
                                            for (int i = 0; i < WhitePiecesPosition.GetLength(0); i++)
                                            {
                                                for (int j = 0; j < WhitePiecesPosition.GetLength(1); j++)
                                                {
                                                    Comeu = false;
                                                    if (WhitePiecesPosition[i, j].Image == null)
                                                    {
                                                        WhitePiecesPosition[i, j].Image = pecaDestinoImage;
                                                        Comeu = true;
                                                        break;
                                                    }
                                                }
                                                if (Comeu == true)
                                                {
                                                    break;
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
                        }
                    }
                }
            }
        }

        private void timerBlackPieces_Tick(object sender, EventArgs e)
        {
            tabuleiro[contadorTabuleiroPretoI, contadorTabuleiroPretoJ].Image = BlackPiecesPosition[contadorPretoI, contadorPretoJ].Image;
            BlackPiecesPosition[contadorPretoI, contadorPretoJ].Image = null;
            contadorTabuleiroPretoJ += 1;
            contadorPretoJ += 1;

            if (contadorPretoJ == 4)
            {
                contadorPretoJ = 0;
                contadorPretoI += 1;
            }

            if (contadorTabuleiroPretoJ == 8)
            {
                contadorTabuleiroPretoI += 1;
                contadorTabuleiroPretoJ = 0;
            }

            if (contadorTabuleiroPretoI == 2)
            {
                timerBlackPieces.Stop();
            }
        }


        private void timerWhitePieces_Tick(object sender, EventArgs e)
        {
            tabuleiro[contadorTabuleiroBrancoI, contadorTabuleiroBrancoJ].Image = WhitePiecesPosition[contadorBrancoI, contadorBrancoJ].Image;
            WhitePiecesPosition[contadorBrancoI, contadorBrancoJ].Image = null;          
            contadorTabuleiroBrancoJ += 1;
            contadorBrancoJ += 1;

            if (contadorBrancoJ == 4)
            {
                contadorBrancoJ = 0;
                contadorBrancoI += 1;
            }

            if (contadorTabuleiroBrancoJ == 8)
            {
                contadorTabuleiroBrancoI -= 1;
                contadorTabuleiroBrancoJ = 0;
            }

            if (contadorTabuleiroBrancoI == 5)
            {
                timerWhitePieces.Stop();
            }
        }
    }
}