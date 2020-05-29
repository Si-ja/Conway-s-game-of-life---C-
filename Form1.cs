using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace GameOfLife
{
    public partial class GUI : Form
    {
        List<List<Cell>> cells2D = new List<List<Cell>>();
        List<float> coordinatesX_cell = new List<float>(); // This will keep a list of all the coordinates on X-axis where cells start
        List<float> coordinatesY_cell = new List<float>(); // This will keep a list of all the coordinates on Y-axis where cells start

        public GUI()
        {
            InitializeComponent();
            DoubleBuffered = true;
        }

        private void GUI_Paint(object sender, PaintEventArgs e)
        {
            // Graphics g = e.Graphics;
            // Field field = new Field();
            // Pen myBlackPen = new Pen(color: Color.Black);
            // g.DrawRectangle(pen: myBlackPen, x: field.x, y: field.y, width: field.width - 1, height: field.height - 1);
        }

        private void btn_GenerateField_Click(object sender, EventArgs e)
        {
            // First we need to keep track of what our field looks like
            Field field = new Field();

            // Then we need to calculate how much space a single cell will be taking in that field
            // In respect to the amount of them on X and Y -axis the user wants to see
            float rows = float.Parse(UpDown_Y.Value.ToString());
            float cols = float.Parse(UpDown_X.Value.ToString());

            float cell_width = field.width / cols;
            float cell_height = field.height / rows;

            // And check how many of the cells should be active
            float cellsCount = rows * cols;
            int activePercentage = (int)Math.Floor(cellsCount * (float.Parse(UpDown_Perc.Value.ToString()) / 100));

            // Now we need to generate all of the needed cell instances 
            List<bool> statesCreate = new List<bool>();
            for (int i = 0; i < cellsCount; i++)
            {
                if (activePercentage > 0)
                {
                    statesCreate.Add(item: true);
                    activePercentage -= 1;
                }
                else
                {
                    statesCreate.Add(item: false);
                }
            }

            // And shuffle the list of those states
            Random rng = new Random();
            List<bool> states = new List<bool>();
            int itterations = statesCreate.Count();
            for (int i = 0; i < itterations; i++)
            {
                int idx = rng.Next(minValue: 0, maxValue: statesCreate.Count());
                states.Add(statesCreate[idx]);
                statesCreate.RemoveAt(index: idx);
            }

            // Now finally we want to generate a list of list of our cells
            // Assign them proper parameters and states so they can be represented on the board
            List<List<Cell>> cells = new List<List<Cell>>();
            // Iterate through what would be a matrix of information for holding of the cells
            // Parellel to that, we want to know general coordinates where cells reside. This helps later with drawing them for the user
            int statesTracker = 0;
            bool xTracker = true;
            // Before we initiate everything - we need to clean our coordinates tracker
            coordinatesX_cell.Clear();
            coordinatesY_cell.Clear();
            for (int iy = 0; iy < rows; iy++)
            {
                // Information on the Y coordinates updates on each pass of rows calculated
                coordinatesY_cell.Add(field.y + cell_height * iy);
                List<Cell> tempCells = new List<Cell>();
                for (int ix = 0; ix < cols; ix++)
                {
                    tempCells.Add(new Cell());
                    tempCells[ix].width = cell_width;
                    tempCells[ix].height = cell_height;
                    tempCells[ix].state = states[statesTracker];
                    tempCells[ix].activityChanged = false; // During generation all changed activity is viewed as non existant
                    tempCells[ix].coordinateY = field.y + cell_height * iy;
                    tempCells[ix].coordinateX = field.x + cell_width * ix;

                    // Information on the X coordinates updates only once
                    if (xTracker)
                    {
                        coordinatesX_cell.Add(field.x + cell_width * ix);
                    }

                    statesTracker++;

                    // And now find all the neighbours by going around the active cell
                    for (int iy2 = iy - 1; iy2 <= iy + 1; iy2++)
                    {
                        for (int ix2 = ix - 1; ix2 <= ix + 1; ix2++)
                        {
                            if (iy2 == iy && ix2 == ix)
                            {
                                continue;
                            } 
                            else
                            {
                                tempCells[ix].neighboursPosition.Add(new List<int> { iy2, ix2 });
                            }
                        }
                    }
                }
                cells.Add(tempCells);
                xTracker = false;
            }
            // Update the internal tracker of what is being worked with
            this.cells2D = cells;

            // The only thing that is left is to draw all of the active cells
            // Because it will have to be re-executed every single time - a method is made and
            // It will be called
            
            DrawCells(cells: this.cells2D);

            // Check if the user wants to have the grid displayed as well
            bool gridStatus = checkBox_Grid.Checked;
            if (gridStatus)
            {
                DrawBorder(cells: this.cells2D);
            }
        }        
        
        private void btn_MakeStep_Click(object sender, EventArgs e)
        {
            UpdateActiveNeighoburs();
            UpdateActivity();
            ReDrawCells(this.cells2D);
            // Check if the user wants to have the grid displayed as well
            bool gridStatus = checkBox_Grid.Checked;
            if (gridStatus)
            {
                DrawBorder(cells: this.cells2D);
            }
        }

        private void btn_Simulate_Click(object sender, EventArgs e)
        {
            // Simulate the steps update automatically
            bool gridStatus = checkBox_Grid.Checked; // Does the user want the grid (?)
            int amountOfSteps = int.Parse(UpDown_SimSteps.Value.ToString());
            var speed = track_Speed.Value;
            for (int i = 0; i < amountOfSteps; i++)
            {
                UpdateActiveNeighoburs();
                UpdateActivity();
                DrawCells(this.cells2D);
                if (gridStatus)
                {
                    DrawBorder(cells: this.cells2D);
                }
                Task.Delay(500 / speed).Wait();
                // Thread.Sleep(1000 / speed);
            }
        }
        
        private void DrawBorder(List<List<Cell>> cells)
        {
            //Draw boarder for a more visual information representation in the game
            Field field = new Field();
            Graphics g = this.CreateGraphics();
            Pen myWhitePen = new Pen(color: Color.White);
            List<float> vLines = new List<float>();

            int i = 0;
            foreach (var rowList in cells)
            {
                // Draw a horizontal Line
                float HStartX = rowList[0].coordinateX;
                float HStopX = HStartX + field.width;
                float HY = rowList[0].coordinateY;
                g.DrawLine(pen: myWhitePen, x1: HStartX, y1: HY, x2: HStopX - 1, y2: HY);

                if (i == 0)
                {
                    foreach (var cell in rowList)
                    {
                        vLines.Add(cell.coordinateX);
                    }
                    vLines.Add(field.x + field.width - 1);
                    i++;
                }
            }
            foreach (var coordinate in vLines)
            {
                g.DrawLine(pen: myWhitePen, x1: coordinate, y1: field.y, x2: coordinate, y2: field.y + field.height);
            }
            g.DrawLine(pen: myWhitePen, x1: field.x, y1: field.y + field.height - 1, x2: field.x + field.width - 1, y2: field.y + field.height - 1);
        }

        private void DrawCells(List<List<Cell>> cells)
        {
            // Draw Cells that are in their active states - For the large field during generation
            Field field = new Field();
            Graphics g = this.CreateGraphics();
            Brush myLightGrayBrush = new SolidBrush(color: Color.LightGray); // For inactive cells
            Brush myBlackBrush = new SolidBrush(color: Color.Black);         // For active cells
            g.FillRectangle(brush: myLightGrayBrush, x: field.x, y: field.y, width: field.width, height: field.height);

            foreach (var rowList in cells)
            {
                foreach (var cell in rowList)
                {
                    
                    if (cell.state == true)
                    {
                        g.FillRectangle(brush: myBlackBrush, x: cell.coordinateX, y: cell.coordinateY, width: cell.width, height: cell.height);
                    }
                }
            }
        }

        private void UpdateActiveNeighoburs()
        {
            List<List<Cell>> newCells = this.cells2D;
            // State of the cells are checked for all of them in respect to their neighbours
            // And it is tracked how many active neighoburs does a cell have
            for (int irow = 0; irow < newCells.Count(); irow++)
            {
                for (int icol = 0; icol < newCells[irow].Count(); icol++)
                {
                    // First assume all neighbours are inactive
                    newCells[irow][icol].activeNeighbours = 0;
                    for (int ineighbour = 0; ineighbour < 8; ineighbour++) // There are always 8 neighbours (including assumed ones)
                    {
                        if (newCells[irow][icol].activeNeighbours >= 4)
                        {
                            break; // We never really care if a cell has more than 4 active neighbours
                        }
                        else
                        {
                            int neighbour_row = this.cells2D[irow][icol].neighboursPosition[ineighbour][0];
                            int neighbour_col = this.cells2D[irow][icol].neighboursPosition[ineighbour][1];
                            try
                            {
                                if (newCells[neighbour_row][neighbour_col].state == true)
                                {
                                    newCells[irow][icol].activeNeighbours += 1;
                                }
                            }
                            catch { }
                        }
                    }
                } 
            }
            this.cells2D = newCells;
        }

        private void UpdateActivity()
        {
            // Updates states of the cells depending on the rules applied to the game
            /* Rules: 
             * For a space that is 'populated':
             * 
                > Each cell with one or no neighbors dies, as if by solitude.
                > Each cell with four or more neighbors dies, as if by overpopulation.
                > Each cell with two or three neighbors survives.

              * For a space that is 'empty' or 'unpopulated'
                > Each cell with three neighbors becomes populated.
            */

            // Evaluate each cell
            foreach (var cellRow in this.cells2D)
            {
                foreach (var cell in cellRow)
                {
                    bool currentState = cell.state;
                    int surroundingActivity = cell.activeNeighbours;
                    if (currentState == true)
                    {
                        if (surroundingActivity <= 1 || surroundingActivity >= 4)
                        {
                            cell.activityChanged = true;
                            cell.state = false;
                        }
                        else
                        {
                            cell.activityChanged = false;
                        }
                    } 
                    else if (currentState == false)
                    {
                        if (surroundingActivity == 3)
                        {
                            cell.activityChanged = true;
                            cell.state = true;
                        } 
                        else
                        {
                            cell.activityChanged = false;
                        }
                    }
                }
            }
        }

        private void ReDrawCells(List<List<Cell>> cells)
        {
            // Only ReDraw those cells that require being redrawn (the ones that changed their state)
            Field field = new Field();
            Graphics g = this.CreateGraphics();
            Brush myLightGrayBrush = new SolidBrush(color: Color.LightGray); // For inactive cells
            Brush myBlackBrush = new SolidBrush(color: Color.Black);         // For active cells

            foreach (var rowList in cells)
            {
                foreach (var cell in rowList)
                {
                    if (cell.activityChanged == true)
                    {
                        if (cell.state == true)
                        {
                            g.FillRectangle(brush: myBlackBrush, x: cell.coordinateX, y: cell.coordinateY, width: cell.width, height: cell.height);
                        }
                        else
                        {
                            g.FillRectangle(brush: myLightGrayBrush, x: cell.coordinateX, y: cell.coordinateY, width: cell.width, height: cell.height);
                        }
                    }
                }
            }
        }

        private void GUI_MouseDown(object sender, MouseEventArgs e)
        {
            Field field = new Field();
            // Check if the cells have been or have not been generated at any point
            if (this.cells2D.Any())
            {
                var toFindX = (float) e.X;
                var toFindY = (float) e.Y;

                int iXtracker = -1;
                int iYtracker = -1;

                // We want to know whether we are working with our coordinates space in the right field
                if (toFindX >= field.x && toFindX <= (field.x + field.width) && toFindY >= field.y && toFindY <= (field.y + field.width))
                {
                    // Find the cell on the X coordinate space
                    for (int iX = 0; iX < coordinatesX_cell.Count(); iX++)
                    {
                        if (toFindX > coordinatesX_cell[iX])
                        {
                            iXtracker++;
                        }
                    }

                    for (int iY = 0; iY < coordinatesY_cell.Count(); iY++)
                    {
                        if (toFindY > coordinatesY_cell[iY])
                        {
                            iYtracker++;
                        }
                    }


                    // Now to finally find the cell we need to update - to active
                    if (radioBtn_Alive.Checked)
                    {
                        if (this.cells2D[iYtracker][iXtracker].state == false)
                        {
                            this.cells2D[iYtracker][iXtracker].state = true;
                            if (this.cells2D[iYtracker][iXtracker].activityChanged == false)
                            {
                                this.cells2D[iYtracker][iXtracker].activityChanged = true;
                            }
                        }
                    }
                    else
                    {
                        if (this.cells2D[iYtracker][iXtracker].state == true)
                        {
                            this.cells2D[iYtracker][iXtracker].state = false;
                            if (this.cells2D[iYtracker][iXtracker].activityChanged == false)
                            {
                                this.cells2D[iYtracker][iXtracker].activityChanged = true;
                            }
                        }
                    }
                    ReDrawCells(this.cells2D);
                } 
                else
                {
                    return;
                }  
            }
        }
    }
}
