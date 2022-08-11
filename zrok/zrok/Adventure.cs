using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zrok
{
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
            player.GetRoom().Describe();
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
