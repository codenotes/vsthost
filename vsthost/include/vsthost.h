extern "C"
{
	void InitializeHost();


	void MIDIDirect(unsigned char * msg, int size, bool isSysex);
	void setPreset(int preset, int midichannel, bool clearChannel);
	void PlayMidiFile(char * midiFileName, unsigned char * channels, int num_channels);
	
	//helper methods, these just create midi sysex messages at end of day
	_declspec(deprecated("** deprecated, doesn't handle banks **")) void setPreset2(int preset, int midichannel, bool clearChannel, int soundFontID);
	void setPreset3(int preset, int bank, int midichannel, bool clearChannel, int soundFontID);
	void unloadSoundFont(char * sfname /*core name*/);
	void loadSoundFont(char * filename);
	void setGain(int gain);
	void getDefaultAudioOutput(char * deviceName);
	int getAudioDevicesWin32(char ***audioDevices, int *sz);
	void releaseAudioDeviceNames(char ***namelist, int sz);

	int getSFID(char * soundfont);
	bool deletePresetMulti(char * soundfont);


}

enum VSTHostProps
{
	
};