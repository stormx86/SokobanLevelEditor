using System;
using System.IO;

namespace SokobanLevelEditor
{
    class LevelFile
    {
        string filename;
        int newLevelSize = 8;
        public LevelFile(string filename)
        {
            this.filename = filename;
        }
        public Cell[,] LoadLevel(int level_nr)
        {
            Cell[,] cell = null;
            string[] lines;
            try
            {
                lines = File.ReadAllLines(filename);
            }
            catch
            {
                return cell;
            }

            int curr = 0;
            int currentLevelNr = 0;
            int width;
            int height;
            while (curr<lines.Length)
            {
            ReadLevelHeader(lines[curr], out currentLevelNr, out width,out height);
            if (level_nr == currentLevelNr)
            {
                cell = new Cell [width,height];
                for (int y = 0; y<height; y++)
                    for (int x=0; x<width;x++)
                        cell[x,y] = CharToCell(lines [curr+1+y] [x]);
            break;
            }
            else curr = curr+1+height;
            }
            if (cell == null)
            {
                Array.Resize(ref lines, lines.Length + newLevelSize+1);
                lines[curr] = (currentLevelNr + 1).ToString() + " " + newLevelSize.ToString() + " " + newLevelSize.ToString();
                for (int j = 0; j < newLevelSize; j++)
                    lines[curr + j + 1] = new String(' ', newLevelSize);
                File.WriteAllLines(filename, lines);
                return LoadLevel(level_nr);
            }
            return cell;
        }

        private void ReadLevelHeader(string line, out int levelNr, out int width, out int height)
        {
            string [] parts = line.Split();
            levelNr = 0;
            width = 0;
            height = 0;
            if (parts.Length !=3)
                return;
            int.TryParse(parts[0], out levelNr);
            int.TryParse(parts[1], out width);
            int.TryParse(parts[2], out height);
        }

        public void SaveLevel(int level_nr, Cell[,] cell)
        {
           string[] lines;
            try
            {
                lines = File.ReadAllLines(filename);
            }
            catch
            {
                return;
            }

            int curr = 0;
            int currentLevelNr;
            int width = 0;
            int height = 0;
            while (curr < lines.Length)
            {
                ReadLevelHeader(lines[curr], out currentLevelNr, out width, out height);
                if (level_nr == currentLevelNr)
                {
                    break;
                }
                else curr = curr + 1 + height;

            }
            int oldLength = lines.Length;
            int delta = cell.GetLength(1) - height;
            int newLength = oldLength + delta;
            if (newLength > oldLength)
            {
                Array.Resize(ref lines, newLength);
                for (int z = newLength - 1; z > curr; z--)
                    lines[z] = lines[z - delta];
            }
            if (newLength < oldLength)
            {
                
                for (int z = curr; z <newLength; z++)
                    lines[z] = lines[z - delta];
                Array.Resize(ref lines, newLength);
            }
            int w = cell.GetLength(0);
            int h = cell.GetLength(1);
            lines[curr] = level_nr.ToString() + " " + w.ToString() + " " + h.ToString();

            for (int y = 0; y < h; y++)
            {
                lines[curr + 1 + y] = "";
                for (int x = 0; x < w; x++)
                    lines[curr + 1 + y] += CellToChar(cell[x,y]);
            }
            try
            {
                File.WriteAllLines(filename, lines);
            }
            catch
            {
                return;
            }
        }


        public Cell CharToCell(char x)
        {
        switch (x)
        {
                case ' ': return Cell.none;
                case '#': return Cell.wall;
                case 'O': return Cell.abox;
                case '.': return Cell.here;
                case 'C': return Cell.done;
                case '1': return Cell.user;
            default : return Cell.none;
        }
        }

        public char CellToChar(Cell c)
        {
        switch (c)
        {
                case Cell.none : return ' ';
                case Cell.wall : return '#';
                case Cell.abox : return 'O';
                case Cell.here : return '.';
                case Cell.done : return 'C';
                case Cell.user : return '1';
            default : return ' ';
        }
        }
    }
}
