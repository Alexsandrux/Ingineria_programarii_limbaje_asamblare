using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seminar3
{
    public class MM_EventArgs : EventArgs
    {
        int cs;
        Bitmap cimg;

        public MM_EventArgs(int cs, Bitmap cimg)
        {
            this.cs = cs;
            this.cimg = cimg;
        }

        public int index_cadru
        {
            get { return this.cs; }
            set { this.cs = value; }
        }

        public Bitmap img_cadru { get { return this.cimg; }}
    }

    public delegate void MM_EventHandler(object sender, MM_EventArgs e);



    public class MM_Animatie
    {
        ArrayList vimag = new ArrayList();
        int imagine_curenta = 0;
        Timer t;

        public MM_Animatie(int interval) // interval is in miliseconds
        {
            t = new Timer();
            t.Interval = interval;
            t.Tick += new EventHandler(actiune);
        }

        public void Add_imag(string s)
        {
            vimag.Add(new Bitmap(s));
        }

        public object this[int z]
        {
            get { return vimag[z]; }
        }

        void actiune(object sender, EventArgs e)
        {
            imagine_curenta++;
            if(imagine_curenta == vimag.Count)
            {
                imagine_curenta = 0;
            }

            if(Schimbare_cadru != null)
            {
                Schimbare_cadru(this, 
                    new MM_EventArgs(imagine_curenta, (Bitmap) vimag[imagine_curenta]));

            }

            //Schimbare_cadru?.Invoke(this,
            //        new MM_EventArgs(imagine_curenta, (Bitmap)vimag[imagine_curenta]);

        }



        public event MM_EventHandler Schimbare_cadru;
        public event MM_EventHandler Terminare_animatie;

        public void Play()
        {
            imagine_curenta = 0;
            t.Start();
        }

        public void Stop()
        {
            if (t.Enabled)
            {
                t.Stop();
            }
            Terminare_animatie?.Invoke(this,
                    new MM_EventArgs(imagine_curenta, (Bitmap)vimag[imagine_curenta]));
        }


    }
}
