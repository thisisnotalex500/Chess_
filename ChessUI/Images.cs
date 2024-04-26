using System;
using System.Collections.Generic;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using ChessLogic;

namespace ChessUI
{
    public static class Images
    {
        private static readonly Dictionary<PieceType, ImageSource> whiteSources = new()
        {
            { PieceType.Pawn, LoadImage("Assets/PawnW.png") },
            { PieceType.Bishop, LoadImage("Assets/PawnW.png") },
            { PieceType.Knight, LoadImage("Assets/PawnW.png") },
            { PieceType.Rook, LoadImage("Assets/PawnW.png") },
            { PieceType.Queen, LoadImage("Assets/PawnW.png") },
            { PieceType.King, LoadImage("Assets/PawnW.png") },



        };

        private static readonly Dictionary<PieceType, ImageSource> blackSources = new()
        {
              { PieceType.Pawn, LoadImage("Assets/PawnB.png") },
            { PieceType.Bishop, LoadImage("Assets/PawnB.png") },
            { PieceType.Knight, LoadImage("Assets/PawnB.png") },
            { PieceType.Rook, LoadImage("Assets/PawnB.png") },
            { PieceType.Queen, LoadImage("Assets/PawnB.png") },
            { PieceType.King, LoadImage("Assets/PawnB.png") },

        };
        private static ImageSource LoadImage(string filePath)
        {
            return new BitmapImage(new Uri(filePath, UriKind.Relative));
        }
                
        public static ImageSource GetImage(Player color, PieceType type)
        {
            return color switch
            {
                Player.White => whiteSources[type],
                Player.Black => blackSources[type],
                _ => null
            };

        }   
        public static ImageSource GetImage(Piece piece)
        {
            if (piece == null)
            {
                return null;
            }
            return GetImage(piece.Color, piece.Type);
        }
    }
}
