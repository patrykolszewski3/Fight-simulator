using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace grafinal
{
    public partial class MainGame : Form       
    {
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        /// <summary>
        /// przechowują wybrane postacie
        /// </summary>
        private Character character1;
        private Character character2;
        int playerTurn = 0;
        

        /// <summary>
        /// zainicjowanie kolekcji tzn. listy obiektów o nazwie "characterList"
        /// </summary>
        List<Character> characterList = new List<Character>(); 

        public MainGame() 
        {
            InitializeComponent();
            player.URL = "Mortal Kombat Theme Song Original.mp3";

            // dodaje nową postać do listy obiektów o nazwie "characterList"
            characterList.Add(new Rekrut("Matt", 33, 23)); 
            characterList.Add(new Rekrut("Elektra", 24, 65));
            characterList.Add(new Rekrut("Stick", 64, 23));
            characterList.Add(new Rekrut("Foggy", 62, 37));
            


            // pętla - dla każdego itemu (obiektu) w characterList
            foreach (var item in characterList) 
            {
                //comboBoxCharacter.Items.Add(item.name); // dodaje nazwę obiektu z listy do comboBoxa
                                                          // ale niestety - tylko nazwe
                comboBoxCharacter.Items.Add(item);        // <--- to dodaje item z tej dziwnej listy do listy comboboxa

               // comboBoxCharacter2.Items.Add(item.name); - 
                comboBoxCharacter2.Items.Add(item);

                Console.WriteLine(item.hp + " <- hp postaci o imieniu " + item.name); // wyświetla cośtam w consoli, raczej pomocniczo to umieściłem żeby sprawdzić czy działa
            }

            

        }

        // reakcja na zmianę postaci wybranej w comboboxie character1
        private void comboBoxCharacter_SelectedIndexChanged(object sender, EventArgs e)
        {
            // wkłada do szufladki "character1" wybrany item z comboboxa
            character1 = (Character)comboBoxCharacter.SelectedItem;
            // do textboxa wyświetlającego ilość hp wrzuca hp z itemu, który jest w szufladce "character1"
            textBoxCharacterHp.Text = character1.hp.ToString();
            // do textboxa wyświetlającego ilość dmg wrzuca dmg z itemu, który jest w szufladce "character1"
            textBoxCharacterDmg.Text = character1.damage.ToString();

            

            

        }
        
        private void buttonAddCharacter_Click(object sender, EventArgs e)
        {
            // tworzy nowy obiekt na podstawie klasy "Rekrut" ze startowymi parametrami, które zaraz i tak będą zmienione
            Rekrut nowyRekrut = new Rekrut("Unknown", 2, 2); 

            // przypisuje nowemu obietowi wartości podane w odpowiednich textBoxach
            nowyRekrut.name = textBoxNewCharacterName.Text; 
            nowyRekrut.hp = Convert.ToInt32(textBoxNewCharacterHp.Text);
            nowyRekrut.damage = Convert.ToInt32(textBoxNewCharacterDamage.Text);


            //dodaje do "characterList" nowo utworzony obiekt
            characterList.Add(nowyRekrut); 
            

            // dodaje do comboBoxów z listami postaci ostatni item (bo ten jest najnowszny) z "characterList"
            comboBoxCharacter.Items.Add(characterList[characterList.Count - 1]); 
            comboBoxCharacter2.Items.Add(characterList[characterList.Count - 1]);

            //Console.WriteLine(characterList.Count); <-- do usunięcia jeżeli wszystko bedzie działać na końcu

        }

        // reakcja na zmianę postaci wybranej w comboboxie character2
        private void comboBoxCharacter2_SelectedIndexChanged(object sender, EventArgs e)
        {
            character2 = (Character)comboBoxCharacter2.SelectedItem;
            textBoxCharacterHp2.Text = character2.hp.ToString();
            textBoxCharacterDmg2.Text = character2.damage.ToString();

        }

        
       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBoxCharacterHp_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNewCharacterHp_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNewCharacterDamage_TextChanged(object sender, EventArgs e)
        {

        }

        // rozpoczęcie gry 
        private void buttonStart_Click(object sender, EventArgs e)
        {

            player.controls.play();
            playerTurn = 1;
            textBoxInformation.Text = "Rozpoczęła się tura gracza 1!";


        }

        // reakcja na atak na ze strony gracza 1 na gracza 2
        private void buttonAttack_Click(object sender, EventArgs e)
        {
            if (playerTurn == 1)
            {

                int lifeModified = int.Parse(textBoxCharacterHp2.Text) - int.Parse(textBoxCharacterDmg.Text);

                textBoxCharacterHp2.Text = lifeModified.ToString();
                playerTurn = 2;
                textBoxInformation.Text = "Rozpoczęła się tura gracza 2!";
            }

        }

        // reakcja na leczenie się gracza 2
        private void button1_Click(object sender, EventArgs e)
        {
            if (playerTurn == 2)
            {


                int lifeModified = int.Parse(textBoxCharacterHp2.Text) + (int.Parse(textBoxCharacterDmg2.Text) / 2);
                    
                textBoxCharacterHp2.Text = lifeModified.ToString();
                playerTurn = 1;
                textBoxInformation.Text = "Rozpoczęła się tura gracza 1!";
            }
        }

        // reakcja na leczenie się gracza 1
        private void buttonDefenseCharacter_Click(object sender, EventArgs e)
        {
            if (playerTurn == 1)
            {


                int lifeModified = int.Parse(textBoxCharacterHp.Text) + (int.Parse(textBoxCharacterDmg.Text) / 2);
                textBoxCharacterHp.Text = lifeModified.ToString();
                playerTurn = 2;
                textBoxInformation.Text = "Rozpoczęła się tura gracza 2!";
            }
        }

        // zakończenie tury bez podejmowania akcji
        private void buttonEndTurn_Click(object sender, EventArgs e)
        {
            
            
                if (playerTurn == 1)
                {
                    playerTurn = 2;
                    textBoxInformation.Text = "Rozpoczęła się tura gracza 2!";
                } else
                {
                    playerTurn = 1;
                    textBoxInformation.Text = "Rozpoczęła się tura gracza 1!";
                }
            

        }

        // reakcja na atak na ze strony gracza 2 na gracza 1
        private void buttonAttackCharacter2_Click(object sender, EventArgs e)
        {
            if (playerTurn == 2)
            {

                int lifeModified = int.Parse(textBoxCharacterHp.Text) - int.Parse(textBoxCharacterDmg2.Text);

                textBoxCharacterHp.Text = lifeModified.ToString();
                    
                playerTurn = 1;
                textBoxInformation.Text = "Rozpoczęła się tura gracza 1!";
            }
        }

       
        // wyświetlanie odpowiedniego komunikatu jeżeli stan zdrowia któregoś z graczy wyniesie 0
        private void textBoxInformation_TextChanged(object sender, EventArgs e)
        {
            int healthPoints = int.Parse(textBoxCharacterHp.Text);
            if (healthPoints <= 0)
            {

                MessageBox.Show("Gracz 1 został pokonany!");

            }
            int healthPoints2 = int.Parse(textBoxCharacterHp2.Text);
            if (healthPoints2 <= 0)
            {

                MessageBox.Show("Gracz 2 został pokonany!");

            }
        }

        private void textBoxCharacterHp2_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            

        }
    }
}
