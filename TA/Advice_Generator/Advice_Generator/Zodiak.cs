using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Advice_Generator
{
    class isiramalan
    {
        public string ramalan1;  
        public string ramalan2;
        public string ramalan3;
        public string ramalan4;
        public string ramalan5;
        public string ramalan6;
        public string ramalan7;
        public string ramalan8;
        public string ramalan9;
        public string ramalan10;
        public string ramalan11;
        public string ramalan12;
        
        public isiramalan()
        {
            ramalan1 = "Today, don't voice your opinion on any subject. If you do, people may reproach you for being an insensitive intellectual who is disconnected from reality. It is very likely that the Water atmosphere which reigns today will make you reject anything that is not deeply felt. So, hug the walls, slip out the side door and go home. You will be able to return with calmer spirits later on.";
            ramalan2 = "This is going to be a day of wide open spaces. Great horizons will be opening up before you and you will be observing people, the city, and the country from a point of view that is extremely gentle and warm. It will be a little like you are an immortal who has gained much wisdom after having lived for several centuries. There is no question that you have a higher awareness. But there is a question as to what you are going to do with that awareness.";
            ramalan3 = "Today's astral alignment, will enable you to harvest the fruit of your labors of the last three weeks. But this will be true only if you make an effort to accept others and their cultures. If you don't, there is a great chance that you will become silent. Being a Cancer, you will be unable to mask your frustrations.";
            ramalan4 = "If you have been looking for a collaboration or a break-through on a personal project, today everything may happen all at once. You may have three or four interviews, meet some new people or have twenty telephone calls that need to be returned. It's always the same and you know it. Nothing in your life seems to come in small doses.";
            ramalan5 = "This is going to be a strange day for someone like you who likes to feel above passion. Well, it is time to adjust, for passion, effusive sentiments and other emotional outbursts are the order of the day. It isn't certain that your wonderful theories and encouraging philosophical perspectives will be exactly welcome in this environment. You are advised to keep your opinions to yourself today.";
            ramalan6 = "A comment or joke that you might find funny is apt to make someone very uncomfortable today. Hold your tongue when you find that you are on the verge of shooting off some sort of potentially offensive remark. People are feeling extra sensitive, and they will most certainly not appreciate blatant rudeness, even if your intention is just to add some humor to the situation. Say something nice, or don't say anything at all.";
            ramalan7 = "You can look forward to a bright day. And what a relief it will be after the tensions of the past several days. This would be a good time to confide in a close friend. This will help to relieve some of the pressure you have been feeling inside. However, be careful not to let yourself relax completely. If you do, you may never be able to get up out of that bed!";
            ramalan8 = "Let the pieces of the situation fall naturally into place. Realize that you don't need to think so much about an issue in order to make sense of it. Usually, your intuition will just know. And it will know today, as long as you trust it. There is a deep inner voice that is crying out for you, and you should make sure you listen carefully. Gossip and meaningless chatter will only cloud your truth even more.";
            ramalan9 = "New winds will begin to blow away the black clouds that have been hovering over you lately. What more could you hope for? Today will seem like a walk in the park in comparison with days past! You will breathe better and come home feeling rested. Try to interact more with the people around you. They will appreciate it if you express a genuine interest in their opinions.";
            ramalan10 = "What you experience today is not likely to be light or frivolous. Keep in mind that there is deep meaning behind every action and reaction, so don't take anything for granted. See the essence behind every situation and adjust your position accordingly. This is a good day to probe and discover. There is a great deal of sensitivity in the air that you should be aware of and latch onto.";
            ramalan11 = "You may be feeling way too serious at the moment. Whether you know it or not, you are in dire need of cheering up. If someone invites you to a comedy dinner show, be all means, go. You may take a half an hour to warm up but you will finish the evening rolling on the floor laughing. It will be the best night of your month! If you can, stop second-guessing yourself.";
            ramalan12 = "Lately, you may have been criticized for being somewhat disorganized and performing tasks in a less than logical manner. Today you will feel that your behavior is perfectly justified. You may be presented with an opportunity to carve out a new niche for your specialty, and leave your detractors speechless with astonishment.";
        }       
    }
    public class Zodiak1
        {            
            string bulansekarang;           
            string result;
            DateTime buatbulan = DateTime.Now;
            public string factorial()
            {
            int blnskrg;
            bulansekarang = buatbulan.Month.ToString();
            blnskrg = Int32.Parse(bulansekarang);
            isiramalan x = new isiramalan();
            
                switch (blnskrg)
                {
                    case 1:
                        result = x.ramalan1;
                        break;
                    case 2:
                        result = x.ramalan2;
                        break;
                    case 3:
                        result = x.ramalan3;
                        break;
                    case 4:
                        result = x.ramalan4;
                        break;
                    case 5:
                        result = x.ramalan5;
                    break;
                    case 6:
                        result = x.ramalan6;
                        break;
                    case 7:
                        result = x.ramalan7;
                        break;
                    case 8:
                        result = x.ramalan8;
                        break;
                    case 9:
                        result = x.ramalan9;
                        break;
                    case 10:
                        result = x.ramalan10;
                        break;
                    case 11:
                        result = x.ramalan11;
                        break;
                    case 12:
                        result = x.ramalan12;
                        break;
                }
                return result;
            }
        }
    class Zodiak2
    {
        string bulansekarang;
        string result;
        DateTime buatbulan = DateTime.Now;
        public string factorial()
        {
            int blnskrg;
            bulansekarang = buatbulan.Month.ToString();
            blnskrg = Int32.Parse(bulansekarang);
            isiramalan x = new isiramalan();
            switch (blnskrg)
            {
                case 1:
                    result = x.ramalan2;
                    break;
                case 2:
                    result = x.ramalan3;
                    break;
                case 3:
                    result = x.ramalan4;
                    break;
                case 4:
                    result = x.ramalan5;
                    break;
                case 5:
                    result = x.ramalan6;
                    break;
                case 6:
                    result = x.ramalan7;
                    break;
                case 7:
                    result = x.ramalan8;
                    break;
                case 8:
                    result = x.ramalan9;
                    break;
                case 9:
                    result = x.ramalan10;
                    break;
                case 10:
                    result = x.ramalan11;
                    break;
                case 11:
                    result = x.ramalan12;
                    break;
                case 12:
                    result = x.ramalan1;
                    break;
            }
            return result;
        }
    }
    class Zodiak3
    {
        string bulansekarang;
        string result;
        DateTime buatbulan = DateTime.Now;
        public string factorial()
        {
            int blnskrg;
           bulansekarang = buatbulan.Month.ToString();
            blnskrg = Int32.Parse(bulansekarang);
            isiramalan x = new isiramalan();
            switch (blnskrg)
            {
                case 1:
                    result = x.ramalan3;
                    break;
                case 2:
                    result = x.ramalan4;
                    break;
                case 3:
                    result = x.ramalan5;
                    break;
                case 4:
                    result = x.ramalan6;
                    break;
                case 5:
                    result = x.ramalan7;
                    break;
                case 6:
                    result = x.ramalan8;
                    break;
                case 7:
                    result = x.ramalan9;
                    break;
                case 8:
                    result = x.ramalan10;
                    break;
                case 9:
                    result = x.ramalan11;
                    break;
                case 10:
                    result = x.ramalan12;
                    break;
                case 11:
                    result = x.ramalan1;
                    break;
                case 12:
                    result = x.ramalan2;
                    break;
            }
            return result;
        }
    }
    class Zodiak4
    {
        string bulansekarang;
        string result;
        DateTime buatbulan = DateTime.Now;
        public string factorial()
        {
            int blnskrg;
            bulansekarang = buatbulan.Month.ToString();
            blnskrg = Int32.Parse(bulansekarang);
            isiramalan x = new isiramalan();
            switch (blnskrg)
            {
                case 1:
                    result = x.ramalan4;
                    break;
                case 2:
                    result = x.ramalan5;
                    break;
                case 3:
                    result = x.ramalan6;
                    break;
                case 4:
                    result = x.ramalan7;
                    break;
                case 5:
                    result = x.ramalan8;
                    break;
                case 6:
                    result = x.ramalan9;
                    break;
                case 7:
                    result = x.ramalan10;
                    break;
                case 8:
                    result = x.ramalan11;
                    break;
                case 9:
                    result = x.ramalan12;
                    break;
                case 10:
                    result = x.ramalan1;
                    break;
                case 11:
                    result = x.ramalan2;
                    break;
                case 12:
                    result = x.ramalan3;
                    break;
            }
            return result;
        }
    }
    class Zodiak5
    {
        string bulansekarang;
        string result;
        DateTime buatbulan = DateTime.Now;
        public string factorial()
        {
            int blnskrg;
            bulansekarang = buatbulan.Month.ToString();
            blnskrg = Int32.Parse(bulansekarang);
            isiramalan x = new isiramalan();
            switch (blnskrg)
            {
                case 1:
                    result = x.ramalan5;
                    break;
                case 2:
                    result = x.ramalan6;
                    break;
                case 3:
                    result = x.ramalan7;
                    break;
                case 4:
                    result = x.ramalan8;
                    break;
                case 5:
                    result = x.ramalan9;
                    break;
                case 6:
                    result = x.ramalan10;
                    break;
                case 7:
                    result = x.ramalan11;
                    break;
                case 8:
                    result = x.ramalan12;
                    break;
                case 9:
                    result = x.ramalan1;
                    break;
                case 10:
                    result = x.ramalan2;
                    break;
                case 11:
                    result = x.ramalan3;
                    break;
                case 12:
                    result = x.ramalan4;
                    break;
            }
            return result;
        }
    }
    class Zodiak6
    {
        string bulansekarang;
        string result;
        DateTime buatbulan = DateTime.Now;
        public string factorial()
        {
            int blnskrg;
            bulansekarang = buatbulan.Month.ToString();
            blnskrg = Int32.Parse(bulansekarang);
            isiramalan x = new isiramalan();
            switch (blnskrg)
            {
                case 1:
                    result = x.ramalan6;
                    break;
                case 2:
                    result = x.ramalan7;
                    break;
                case 3:
                    result = x.ramalan8;
                    break;
                case 4:
                    result = x.ramalan9;
                    break;
                case 5:
                    result = x.ramalan10;
                    break;
                case 6:
                    result = x.ramalan11;
                    break;
                case 7:
                    result = x.ramalan12;
                    break;
                case 8:
                    result = x.ramalan1;
                    break;
                case 9:
                    result = x.ramalan2;
                    break;
                case 10:
                    result = x.ramalan3;
                    break;
                case 11:
                    result = x.ramalan4;
                    break;
                case 12:
                    result = x.ramalan5;
                    break;
            }
            return result;
        }
    }
    class Zodiak7
    {
        string bulansekarang;
        string result;
        DateTime buatbulan = DateTime.Now;
        public string factorial()
        {
            int blnskrg;
            bulansekarang = buatbulan.Month.ToString();
            blnskrg = Int32.Parse(bulansekarang);
            isiramalan x = new isiramalan();
            switch (blnskrg)
            {
                case 1:
                    result = x.ramalan7;
                    break;
                case 2:
                    result = x.ramalan8;
                    break;
                case 3:
                    result = x.ramalan9;
                    break;
                case 4:
                    result = x.ramalan10;
                    break;
                case 5:
                    result = x.ramalan11;
                    break;
                case 6:
                    result = x.ramalan12;
                    break;
                case 7:
                    result = x.ramalan1;
                    break;
                case 8:
                    result = x.ramalan2;
                    break;
                case 9:
                    result = x.ramalan3;
                    break;
                case 10:
                    result = x.ramalan4;
                    break;
                case 11:
                    result = x.ramalan5;
                    break;
                case 12:
                    result = x.ramalan6;
                    break;
            }
            return result;
        }
    }
    class Zodiak8
    {
        string bulansekarang;
        string result;
        DateTime buatbulan = DateTime.Now;
        public string factorial()
        {
            int blnskrg;
            bulansekarang = buatbulan.Month.ToString();
            blnskrg = Int32.Parse(bulansekarang);
            isiramalan x = new isiramalan();
            switch (blnskrg)
            {
                case 1:
                    result = x.ramalan8;
                    break;
                case 2:
                    result = x.ramalan9;
                    break;
                case 3:
                    result = x.ramalan10;
                    break;
                case 4:
                    result = x.ramalan11;
                    break;
                case 5:
                    result = x.ramalan12;
                    break;
                case 6:
                    result = x.ramalan1;
                    break;
                case 7:
                    result = x.ramalan2;
                    break;
                case 8:
                    result = x.ramalan3;
                    break;
                case 9:
                    result = x.ramalan4;
                    break;
                case 10:
                    result = x.ramalan5;
                    break;
                case 11:
                    result = x.ramalan6;
                    break;
                case 12:
                    result = x.ramalan7;
                    break;
            }
            return result;
        }
    }
    class Zodiak9
    {
        string bulansekarang;
        string result;
        DateTime buatbulan = DateTime.Now;
        public string factorial()
        {
            int blnskrg;
            bulansekarang = buatbulan.Month.ToString();
            blnskrg = Int32.Parse(bulansekarang);
            isiramalan x = new isiramalan();
            switch (blnskrg)
            {
                case 1:
                    result = x.ramalan9;
                    break;
                case 2:
                    result = x.ramalan10;
                    break;
                case 3:
                    result = x.ramalan11;
                    break;
                case 4:
                    result = x.ramalan12;
                    break;
                case 5:
                    result = x.ramalan1;
                    break;
                case 6:
                    result = x.ramalan2;
                    break;
                case 7:
                    result = x.ramalan3;
                    break;
                case 8:
                    result = x.ramalan4;
                    break;
                case 9:
                    result = x.ramalan5;
                    break;
                case 10:
                    result = x.ramalan6;
                    break;
                case 11:
                    result = x.ramalan7;
                    break;
                case 12:
                    result = x.ramalan8;
                    break;
            }
            return result;
        }
    }
    class Zodiak10
    {
        string bulansekarang;
        string result;
        DateTime buatbulan = DateTime.Now;
        public string factorial()
        {
            int blnskrg;
            bulansekarang = buatbulan.Month.ToString();
            blnskrg = Int32.Parse(bulansekarang);
            isiramalan x = new isiramalan();
            switch (blnskrg)
            {
                case 1:
                    result = x.ramalan10;
                    break;
                case 2:
                    result = x.ramalan11;
                    break;
                case 3:
                    result = x.ramalan12;
                    break;
                case 4:
                    result = x.ramalan1;
                    break;
                case 5:
                    result = x.ramalan2;
                    break;
                case 6:
                    result = x.ramalan3;
                    break;
                case 7:
                    result = x.ramalan4;
                    break;
                case 8:
                    result = x.ramalan5;
                    break;
                case 9:
                    result = x.ramalan6;
                    break;
                case 10:
                    result = x.ramalan7;
                    break;
                case 11:
                    result = x.ramalan8;
                    break;
                case 12:
                    result = x.ramalan9;
                    break;
            }
            return result;
        }
    }
    class Zodiak11
    {
        string bulansekarang;
        string result;
        DateTime buatbulan = DateTime.Now;
        public string factorial()
        {
            int blnskrg;
            bulansekarang = buatbulan.Month.ToString();
            blnskrg = Int32.Parse(bulansekarang);
            isiramalan x = new isiramalan();
            switch (blnskrg)
            {
                case 1:
                    result = x.ramalan11;
                    break;
                case 2:
                    result = x.ramalan12;
                    break;
                case 3:
                    result = x.ramalan1;
                    break;
                case 4:
                    result = x.ramalan2;
                    break;
                case 5:
                    result = x.ramalan3;
                    break;
                case 6:
                    result = x.ramalan4;
                    break;
                case 7:
                    result = x.ramalan5;
                    break;
                case 8:
                    result = x.ramalan6;
                    break;
                case 9:
                    result = x.ramalan7;
                    break;
                case 10:
                    result = x.ramalan8;
                    break;
                case 11:
                    result = x.ramalan9;
                    break;
                case 12:
                    result = x.ramalan10;
                    break;
            }
            return result;
        }
    }
    class Zodiak12
    {
        string bulansekarang;
        string result;
        DateTime buatbulan = DateTime.Now;
        public string factorial()
        {
            int blnskrg;
            bulansekarang = buatbulan.Month.ToString();
            blnskrg = Int32.Parse(bulansekarang);
            isiramalan x = new isiramalan();
            switch (blnskrg)
            {
                case 1:
                    result = x.ramalan12;
                    break;
                case 2:
                    result = x.ramalan1;
                    break;
                case 3:
                    result = x.ramalan2;
                    break;
                case 4:
                    result = x.ramalan3;
                    break;
                case 5:
                    result = x.ramalan4;
                    break;
                case 6:
                    result = x.ramalan5;
                    break;
                case 7:
                    result = x.ramalan6;
                    break;
                case 8:
                    result = x.ramalan7;
                    break;
                case 9:
                    result = x.ramalan8;
                    break;
                case 10:
                    result = x.ramalan9;
                    break;
                case 11:
                    result = x.ramalan10;
                    break;
                case 12:
                    result = x.ramalan11;
                    break;
            }
            return result;
        }
    }
}



