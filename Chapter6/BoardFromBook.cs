
namespace Chapter6
{
    using System.Collections.Generic;

    public class BoardFromBook
    {
        private int _width, _height;
        private List<List<Tile>> _tiles;

        public BoardFromBook(int width, int height)
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

        public Tile GetTile(int x, int y)
        {
            if (x < 1 || x > _width || y < 1 || y > _height)
            {
                throw new ArgumentOutOfRangeException("Invalid tile coordinates");
            }

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
}