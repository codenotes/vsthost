extern "C"
{
	void InitializeHost();


	void MIDIDirect(unsigned char * msg, int size, bool isSysex);
	void setPreset(int preset, int midichannel, bool clearChannel);
	
	


}