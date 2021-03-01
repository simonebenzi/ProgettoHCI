using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCI_Project
{
    public class IniParser
    {
        private Hashtable pairs = new Hashtable();
        private string path;

        private struct SectionPair
        {
            public string Section;
            public string Key;
        }
        public IniParser(String path)
        {
            TextReader file = null;
            String line = null;
            String currentRoot = null;
            String[] pair = null;

            this.path = path;
            try
            {
                file = new StreamReader(path);

                line = file.ReadLine();

                while (line != null)
                {
                    line = line.Trim().ToUpper();

                    if (line != "")
                    {
                        if (line.StartsWith("[") && line.EndsWith("]"))
                        {
                            currentRoot = line.Substring(1, line.Length - 2);
                        }
                        else if (line.StartsWith(";"))
                        {

                        }
                        else
                        {
                            pair = line.Split(new char[] { '=' }, 2);

                            SectionPair sectionPair;
                            String value = null;

                            if (currentRoot == null)
                                currentRoot = "ROOT";

                            sectionPair.Section = currentRoot;
                            sectionPair.Key = pair[0];

                            if (pair.Length > 1)
                                value = pair[1];

                            pairs.Add(sectionPair, value);
                        }
                    }
                    line = file.ReadLine();
                }
            }
            catch(FileNotFoundException e) // If there is not "config.ini" file, it is created 
            {
                AddSetting("Language", "langSelection", ((int)Settings.langSelection).ToString());
                AddSetting("Rows", "minRow", Settings.minRows.ToString());
                AddSetting("Rows", "maxRow", Settings.maxRows.ToString());
                AddSetting("Columns", "minCol", Settings.minCols.ToString());
                AddSetting("Columns", "maxCol", Settings.maxCols.ToString());
                AddSetting("Moves", "maxMoves", Settings.maxMoves.ToString());
                String temp = ReverseLinkColor(Settings.tilesColor);
                AddSetting("Colors", "tilesColor", temp);
                temp = ReverseLinkColor(Settings.wrongTilesColor);
                AddSetting("Colors", "wrongTilesColor", temp);
                temp = ReverseLinkColor(Settings.moveTilesColor);
                AddSetting("Colors", "moveTilesColor", temp);
                temp = ReverseLinkColor(Settings.backgroundColor);
                AddSetting("Colors", "backgroundColor", temp);
                temp = ReverseLinkColor(Settings.rectBackgroundColor);
                AddSetting("Colors", "rectBackgroundColor", temp);
                SaveFile(path);
            }
            finally
            {
                if (file != null)
                    file.Close();
            }
        }

        // Added just some colors, developers can modify this method to add others
        private String ReverseLinkColor(Color color)
        {
            if (color == Color.Black)
                return "BLACK";
            else if (color == Color.Red)
                return "RED";
            else if (color == Color.Gray)
                return "GRAY";
            else
                return "WHITE";
        }

        // Return the value of a given setting
        public String GetSetting(String section, String setting)
        {
            SectionPair sectionPair;
            sectionPair.Section = section.ToUpper();
            sectionPair.Key = setting.ToUpper();

            return (String)pairs[sectionPair];
        }

        // Add or replace a setting to the table
        public void AddSetting(String section, String setting, String value)
        {
            SectionPair sectionPair;
            sectionPair.Section = section.ToUpper();
            sectionPair.Key = setting.ToUpper();

            if (pairs.ContainsKey(sectionPair))
                pairs.Remove(sectionPair);

            pairs.Add(sectionPair, value);
        }

        // Save settings in the file 
        public void SaveFile(String newFilePath)
        {
            ArrayList sections = new ArrayList();
            String tmpValue = "";
            String strToSave = "";

            foreach (SectionPair sectionPair in pairs.Keys)
            {
                if (!sections.Contains(sectionPair.Section))
                    sections.Add(sectionPair.Section);
            }

            foreach (String section in sections)
            {
                strToSave += ("[" + section + "]\r\n");

                foreach (SectionPair sectionPair in pairs.Keys)
                {
                    if (sectionPair.Section == section)
                    {
                        tmpValue = (String)pairs[sectionPair];

                        if (tmpValue != null)
                            tmpValue = "=" + tmpValue;

                        strToSave += (sectionPair.Key + tmpValue + "\r\n");
                    }
                }

                strToSave += "\r\n";
            }

            try
            {
                TextWriter tw = new StreamWriter(newFilePath);
                tw.Write(strToSave);
                tw.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // Update setting and save it on the file
        public void UpdateSetting(String section, String setting, String value)
        {
            AddSetting(section, setting, value);
            SaveFile(this.path);
        }
    }
}
