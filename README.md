CR_Fader
========
CR_Fader will reduce the visibility of any lines of your code which start with certain prefixes.
The idea is to allow you to more easily ignore lines of code which do not contribute to the Logic of your code.

Configuration
=============
Configuration of Prefixes is available through the CodeRush options (DevExpress\CodeRush\Options)
    
    - Locate the 'Editor\Painting\Fader' Options page.
    - Populate the Prefixes list with any strings you wish to use to reduce code visibility.

Example
=======
    You might decide that you'd like to reduce the visibility of lines which perform logging.
    In this case you might add the prefixes of '_Log' or 'mLog' (without quotes) as suits your coding style preferences.
