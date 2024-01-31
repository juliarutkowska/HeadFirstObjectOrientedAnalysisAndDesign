namespace Chapter6;

using System.Collections.Generic;

    public class BoardFromBook
    {
        private int _width, _height;
        private List<List<Tile>> _tiles;


        public void Board(int width, int height)
        {
            _width = width;
            _height = height;
            Initialize();
        }

        private void Initialize()
        {
            _tiles = new List<List<Tile>>(_width);

            for (var i = 0; i < _width; i++)
            {
                _tiles.Add(new List<Tile>(_height));
                for (var j = 0; j < _height; j++)
                {
                    _tiles[i].Add(new Tile());
                }
            }
        }

        private Tile GetTile (int x, int y)
        {
            return _tiles[x - 1][y - 1];
        }

        public void AddUnit(Unit unit, int x, int y)
        {
            var tile = GetTile(x, y);
            tile.AddUnit(unit);
        }

        public void RemoveUnit(Unit unit, int x, int y)
        {
            var tile = GetTile(x, y);
            tile.RemoveUnit(unit);
        }

        public void RemoveUnits(int x, int y)
        {
            var tile = GetTile(x, y);
            tile.RemoveUnits();
        }

        public List<Unit> GetUnits(int x, int y)
        {
            return GetTile(x, y).GetUnits();
        }
    }

    