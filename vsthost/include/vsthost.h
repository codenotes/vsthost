extern "C"
{
	void InitializeHost();


	void MIDIDirect(unsigned char * msg, int size, bool isSysex);
	void setPreset(int preset, int midichannel, bool clearChannel);
	void PlayMidiFile(char * midiFileName, unsigned char * channels, int num_channels);
	
	//conveiniance methods, these just create midi sysex messages at end of day
	void setPreset2(int preset, int midichannel, bool clearChannel, int soundFontID);
	void loadSoundFont(char * filename);
	void setGain(int gain);
	


}

enum VSTHostProps
{
	
};