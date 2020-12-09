#------Psuedo Code----------#
    #---Selenium Side---#
        # Open Wani Kani
        # Go to desired Kanji Level  
        # Grab Kanji 
        # Grab Onyomi - Unless it's None 
        # Grab Kunyomi - Unless it's None 
        # Grab Nanori - Unless it's None 
        # Go To next Kanji 
        # repeat from step 3 - Unless it's the last kanji in Level

    #---Text Editor Side ---#
        # Receive kanji collection
        # Create New Document  
        # Print in this format : 

            #上 (Meaning)	Above
            #上 (Onyomi)		じよう
            #上（Kunyomi）	 うえ、 あ、 のぼ、 うわ、 かみ
        #
        # Save Document 
        # Don't Profit 



import os
import re
from selenium import webdriver
from selenium.webdriver.chrome.options import Options



class Kanji :


    def __init__(self, symbol, meaning, onyomi='', kunyomi='', nanori='') :
        self.symbol = symbol
        self.meaning = meaning
        self.onyomi = onyomi
        self.kunyomi = kunyomi
        self.nanori = nanori


    def NoneCheck(self, kanji) :
        if kanji.onyomi == 'None' :
            setattr(kanji, 'onyomi', '')
        if kanji.kunyomi == 'None' :
            setattr(kanji, 'kunyomi', '')
        if kanji.nanori == 'None' :
            setattr(kanji, 'nanori', '')



class Vocab :


    def __init__(self, symbols, meaning, reading_one, reading_two) :
        self.symbols = symbols
        self.meaning = meaning
        self.reading_one = reading_one
        self.reading_two = reading_two


    def DuplCheck(self, vocab) :
        if vocab.reading_one == vocab.reading_two :
            vocab.reading_two = ''



class WaniKani : 

    
    Info_Collection = []
    Section = ['kanji', 'vocabulary']
    Realms = ['pleasant', 'painful', 'death', 'hell', 'paradise', 'reality' ]
    
    

    #Starting Webdriver and going to WaniKani / Section and Level
    @classmethod
    def ENoTabi_WaniKani(self, section, realm, level) :
        global driver
        options = Options()
        options.add_argument('--headless')
        options.add_argument('--disable-gpu')
        driver = webdriver.Chrome(executable_path='/Users/frederick/Documents/REPOS/WaniKani_Card_Generator/WaniKani_CardSet_Creator/chromedriver', chrome_options=options) 
        #initializing driver and driver options so it can run without opening chrome window 

        driver.get(f"https://www.wanikani.com/{section}?difficulty={realm}")
        driver.find_element_by_css_selector(f'#level-{level} a[href]').click()
        #Going to Wanikani.com section and clicking on first element under level


    # Grabbing Kanji/Vocab Information and returning it 
    def Tsukamu(self, section) : 
        symbol =  "".join(set(driver.find_element_by_css_selector(f'.{section}-icon').text.lstrip()))

        meaning = driver.find_element_by_css_selector('header > h1').text
        meaning = meaning[:0] + meaning[4:]

        if section == 'kanji' : 
            readings = driver.find_elements_by_css_selector('.span4 > p')
            kanji = Kanji(symbol, meaning.lstrip(), readings[0].text, readings[1].text, readings[2].text)
            return kanji 
        else :
            readings = driver.find_elements_by_css_selector('.pronunciation-variant')
            vocab = Vocab(symbol, meaning.lstrip(), readings[0].text, readings[-1].text)
            return vocab


    # Going to next Kanji/Vocab in level
    def Tsugi(self) :
        driver.implicitly_wait(3)
        driver.find_element_by_css_selector('.next a').click()


    # Grabbing all Kanji/Vocab in the level
    def Atsumeru(self, section, realm, level) :
        self.ENoTabi_WaniKani(section, realm, level)
        while True :
            try:
                Site.Info_Collection.append(Site.Tsukamu(section))
                print(self.Info_Collection[-1].symbol, self.Info_Collection[-1].meaning)
                Site.Tsugi()
            except:
                print('No More Info In Current Level') 
                driver.quit()
                break


    # Creating document in format for Quizlet
    def Create_Cards(self, section, realm, level, info_Collection) :
        cards = open(os.getcwd() + '/Quizlet_Cards/' + f"{section}_{realm}_{level}.rtf", "w+")

        if section == 'kanji' : 
            for kanji in info_Collection : 
                kanji.NoneCheck(kanji)
                cards.write(
                    f"{kanji.symbol} (Meaning)      {kanji.meaning}\n"+
                    f"{kanji.symbol} (Onyomi)       {kanji.onyomi}\n" + 
                    f"{kanji.symbol} (Kunyomi)      {kanji.kunyomi}\n"+
                    f"{kanji.symbol} (Nanori)       {kanji.nanori}\n"  
                    )
        else:
            for vocab in info_Collection : 
                vocab.DuplCheck()
                cards.write(
                    f"{vocab.symbol} (Meaning)      {vocab.meaning}\n" +
                    f"{vocab.symbol} (Reading 1)    {vocab.reading_one}\n" + 
                    f"{vocab.symbol} (Reading 2)    {vocab.reading_two}\n" 
                    )


        cards.close() 
    


        








#Script Run 
Site = WaniKani()

section = Site.Section[0]
realm = Site.Realms[0]
level = 2
#Choose option here 

Site.Atsumeru(section, realm, level)
Site.Create_Cards(section, realm, level, Site.Info_Collection)


# -------------Key------------- #

# Sections 
    # 0 : kanji
    # 1 : vocabulary

# Levels Relative to Realms
    # 0 : pleasant : 1 - 10
    # 1 : painful : 11 - 20
    # 2 : death : 21 - 30 
    # 3 : hell : 31 - 40
    # 4 : paradise : 41 - 50 
    # 5 : reality : 51 - 60 

#------Regex to get rid of empty lines : \W\s\(\w+\)\s+\n------#