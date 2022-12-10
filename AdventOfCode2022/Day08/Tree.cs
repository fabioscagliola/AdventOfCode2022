namespace com.fabioscagliola.AdventOfCode2022.Day08
{
    public class Tree
    {
        public PatchOfTrees PatchOfTrees { get; protected set; }

        public int Height { get; protected set; }

        public int RowIndex { get; protected set; }

        public int ColIndex { get; protected set; }

        public Tree(PatchOfTrees patchOfTrees, int rowIndex, int colIndex, int height)        {
            PatchOfTrees = patchOfTrees;
            RowIndex = rowIndex;
            ColIndex = colIndex;
            Height = height;
        }

        public bool IsVisible
        {
            get
            {
                if (RowIndex == 0 || ColIndex == 0 || RowIndex == PatchOfTrees.Count - 1 || ColIndex == PatchOfTrees[RowIndex].Count - 1)
                    return true;

                return IsVisibleFromTheB || IsVisibleFromTheL || IsVisibleFromTheR || IsVisibleFromTheT;
            }
        }

        public int ScenicScore
        {
            get
            {
                if (RowIndex == 0 || ColIndex == 0 || RowIndex == PatchOfTrees.Count - 1 || ColIndex == PatchOfTrees[RowIndex].Count - 1)
                    return 0;

                return ViewingDistanceB * ViewingDistanceL * ViewingDistanceR * ViewingDistanceT;
            }
        }

        protected bool IsVisibleFromTheB
        {
            get
            {
                for (int r = RowIndex + 1; r < PatchOfTrees[RowIndex].Count; r++)
                    if (PatchOfTrees[r][ColIndex].Height >= Height)
                        return false;
                return true;
            }
        }

        protected bool IsVisibleFromTheL
        {
            get
            {
                for (int c = ColIndex - 1; c > -1; c--)
                    if (PatchOfTrees[RowIndex][c].Height >= Height)
                        return false;
                return true;
            }
        }

        protected bool IsVisibleFromTheR
        {
            get
            {
                for (int c = ColIndex + 1; c < PatchOfTrees[ColIndex].Count; c++)
                    if (PatchOfTrees[RowIndex][c].Height >= Height)
                        return false;
                return true;
            }
        }

        protected bool IsVisibleFromTheT
        {
            get
            {
                for (int r = RowIndex - 1; r > -1; r--)
                    if (PatchOfTrees[r][ColIndex].Height >= Height)
                        return false;
                return true;
            }
        }

        public int ViewingDistanceB
        {
            get
            {
                int result = 1;

                for (int r = RowIndex + 1; r < PatchOfTrees[RowIndex].Count - 1; r++)
                    if (PatchOfTrees[r][ColIndex].Height < Height)
                        result++;
                    else
                        break;

                return result;
            }
        }

        public int ViewingDistanceL
        {
            get
            {
                int result = 1;

                for (int c = ColIndex - 1; c > 0; c--)
                    if (PatchOfTrees[RowIndex][c].Height < Height)
                        result++;
                    else
                        break;

                return result;
            }
        }

        public int ViewingDistanceR
        {
            get
            {
                int result = 1;

                for (int c = ColIndex + 1; c < PatchOfTrees[ColIndex].Count - 1; c++)
                    if (PatchOfTrees[RowIndex][c].Height < Height)
                        result++;
                    else
                        break;

                return result;
            }
        }

        public int ViewingDistanceT
        {
            get
            {
                int result = 1;

                for (int r = RowIndex - 1; r > 0; r--)
                    if (PatchOfTrees[r][ColIndex].Height < Height)
                        result++;
                    else
                        break;

                return result;
            }
        }
    }
}
