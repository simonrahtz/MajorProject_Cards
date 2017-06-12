using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Shared
{

    static class BinaryFiles
    {


        public static void writeData(string filename, LinkedList list)
        {
            BinaryWriter bw;



            try
            {
                bw = new BinaryWriter(File.Open(filename, FileMode.Create));

            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message + "cannot write to file");
                return;
            }
            try
            {
                int length = list.getListLength();
                bw.Write(length);
                Card card;

                for (int i = 0; i < length; i++)
                {
                    card = list.GetIndex(i);


                    bw.Write((int)card.getSuit());
                    bw.Write((int)card.getValue());

                }

                Console.WriteLine("success");
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message + "cannot write to file");
            }
            bw.Close();
        }
        public static void readData(string fileName, LinkedList playerHand)
        {
            BinaryReader br;
            if (File.Exists(fileName))
            {
                try
                {
                    br = new BinaryReader(File.Open(fileName, FileMode.Open));

                }
                catch (IOException e)
                {
                    Console.WriteLine(e.Message + "cannot open from file");
                    return;
                }


                Suits suit;
                Values value;

                try
                {

                    int length = br.ReadInt32();

                    for (int i = 0; i < length; i++)
                    {
                        suit = (Suits)br.ReadInt32();
                        value = (Values)br.ReadInt32();

                        playerHand.addValue(new Card(suit, value));
                        Console.WriteLine("success");
                    }



                }
                catch (IOException e)
                {
                    Console.WriteLine(e.Message + "cannot read file");
                    return;
                }
                br.Close();

            }
            else
                Console.WriteLine("file does not exist");
        }


    }
}
