import pyttsx3
import datetime
a1=pyttsx3.init()
voice=a1.getProperty('voices')
a1.setProperty('voice',voice[1].id)

def speak(audio):
	print("Assistant Risu-1: "+ audio)
	a1.say(audio)
	a1.runAndWait()
speak("Hello")
speak("Youtube")
speak("Google")
speak("init")
speak("Nasus")
speak("Akali")