using System;

namespace ChatApplication.Shared
{
	// Used to display messages
    public class Message
    {
		// Will be used to determine how to display
		public bool? IsSystem { get; set; }

		// Time message was sent
		public string Timestamp { get; set; }

		// Who sent the message displayed
		public string User { get; set; }

		// Message to be displayed
		public string MessageText { get; set; }

		// Colour text bubble to display
		public Tuple<int, int, int> Color { get; set; }

		// Deafult Constructor
		public Message()
		{
			
		}

		// Overloaded Constructor
		public Message( bool isSystem, string user, string text )
		{

			IsSystem = isSystem;  
			User = user;
			MessageText = text;

			// Set timestamp to when the message was created
			Timestamp = DateTime.Now.ToString("HH:mm");

			/* Set the colour of the message depending type of sender
			 * 
			 * User messages -> pale green
			 * System messages -> dark slate gray
			 */
			Color = new Tuple<int, int, int>( 152, 251, 152 );
			if ( isSystem )
            {
				Color = new Tuple<int, int, int>( 47, 79, 79 );
			}
		}
    }
}