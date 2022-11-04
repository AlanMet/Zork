using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zrok
{
    [Serializable()]
    public partial class Adventure
    {

        private Player player;

        public Adventure()
        {
            player = new Player();
            InitVocab();
        }

        public void Describe()
        {
            if (player.GetRoom().GetEntered())
            {
                player.GetRoom().SimpleDescribe();
            }
            else
            {
                player.GetRoom().Describe();
            }
        }

        public Player GetPlayer()
        {
            return this.player;
        }

        //commands
        //move
        //look
        //save
        //restore
        //restart
        //verbose
        //score
        //diagnostic
        //brief
        //superbrief
        //climb
        //g
        //enter
        //


    }
}
