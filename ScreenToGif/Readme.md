# ScreenToGif  

This is the current project of ScreenToGif.  

_VS 2019 and .Net 4.8 or newer required._

## What's new? (Version 2.33.1)

• Nothing yet.

### Fixed:

♦ The option to change the editor's background based on the system's theme was not working properly (it was behaving as if it was always on).
♦ When stopping a recording by using a keyboars shortcut, the confirmation dialog to delete the previous project was not getting focus (thanks to @pawlos).
♦ When minimizing the new recorder UI by left-clicking once the system's tray icon, the region selection was not minimizing along.  
♦ The editor window was not appearing on the correct screen after closing and opening again (when maximized).

### Known Bugs:
  
♠ When exporting with FFmpeg, the last frame may be out of sync with the timmings of the project.  
♠ Cancelling a encoding of FFmpeg will result in a crash (file in use).  
♠ Keystrokes has a 1 pixel transparent border at the bottom-right sides when using a high DPI screen.  
♠ The newer recorder doesn't let you move the selected region to other windows.  
♠ When using the capture option "Capture a frame only when something changes on screen" and moving the recording window, the recording will glitch.  
♠ The Previous/Next repeat buttons are only triggering the events once (because of the command).   
♠ Holding the side arrows to seek the frames for a long period makes the scrubing act jump frames.  
♠ Capturing with DirectX using a screen not in landscaped mode results in a rotated frame.