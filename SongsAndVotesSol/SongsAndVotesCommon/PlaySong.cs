using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio.Wave;

namespace SongsAndVotesCommon
{
    public class PlaySong
    {
        public void PlayOneSong()
        {
            AudioFileReader audioFile = null;
            WaveOutEvent outputDevice = null;
            try
            {
                string audioFilePath = @"C:\Users\DJTom\OneDrive\Plocha\20201007_hodina\SongsAndVotesSol\Resources\Peter_Nemec_-_Future_Life_OFFICIAL_LYRICS_VIDEO_1.mp3";
                audioFile = new AudioFileReader(audioFilePath);
                outputDevice = new WaveOutEvent();

                outputDevice.Init(audioFile);
                outputDevice.Play();

                Console.ReadKey(true);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey(true);
            }
            finally
            {
                if (outputDevice != null)
                {
                    outputDevice.Stop();
                    outputDevice.Dispose();
                }
                if (audioFile != null)
                {
                    audioFile.Close();
                    audioFile.Dispose();
                }
            }

        }
    }
}
