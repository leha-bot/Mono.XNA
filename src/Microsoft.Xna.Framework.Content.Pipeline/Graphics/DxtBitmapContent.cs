// DxtBitmapContent.cs created with MonoDevelop
// User: lars at 03.08 07.03.09
//
// To change standard headers go to Edit->Preferences->Coding->Standard Headers
//

using System;

namespace Microsoft.Xna.Framework.Content.Pipeline.Graphics
{
	
	
	public abstract class DxtBitmapContent : BitmapContent
	{

#region Constructor
		
		protected DxtBitmapContent(int blockSize)
		{
			
		}
		
		protected DxtBitmapContent(int blockSize, int width, int height)
		{
			
		}
			
#endregion
			
#region Public Methods

		public override byte[] GetPixelData()
		{
			throw new NotImplementedException();
		}

		public override void SetPixelData(byte[] sourceData)
		{
			throw new NotImplementedException();
		}
		
#endregion
		
#region Protected Methods

		protected override bool TryCopyFrom(BitmapContent sourceBitmap, Rectangle sourceRegion, Rectangle destinationRegion)
		{
			throw new NotImplementedException();
		}
		
		protected override bool TryCopyTo(BitmapContent destinationBitmap, Rectangle sourceRegion, Rectangle destinationRegion)
		{
			throw new NotImplementedException();
		}
		
#endregion
			
	}
}
