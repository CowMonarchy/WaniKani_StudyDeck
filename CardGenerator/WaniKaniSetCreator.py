from selenium import webdriver
from selenium.webdriver.common.by import By
from selenium.webdriver.common.keys import Keys 
from selenium.webdriver.chrome.options import Options
from selenium.webdriver.support.ui import WebDriverWait
from selenium.webdriver.support import expected_conditions as EC



class Kanji :

    def __init__(self, symbol, reading, meaning) :
        self.symbol = symbol
        self.meaning = meaning
        self.reading = reading


class Vocab :

    def __init__(self, symbol, reading, meanings, partOfSpeech, soundLink01, soundLink02) :
        self.symbol = symbol
        self.reading = reading
        self.meanings = meanings
        self.partOfSpeech = partOfSpeech
        self.soundLink01 = soundLink01
        self.soundLink02 = soundLink02



class WaniKani : 



    @classmethod
    def ENoTabi_WaniKani(self, level) :
        global driver
        global wait
        options = Options()
        #options.add_argument('--headless')
        #options.add_argument('--disable-gpu')
        driver = webdriver.Chrome(executable_path='/Users/fredericklindsey/Documents/Repositories/Completed/VocabCreatorStudy/CardGenerator/chromedriver', chrome_options=options) 
        wait = WebDriverWait(driver, 5)
        #initializing driver and driver options so it can run without opening chrome window 

        driver.get(f"https://www.wanikani.com/level/{level}")
        #Going to Wanikani.com and starting level



    def GrabKanji(self) : 
        kanjiList = []
        kanjiElements = driver.find_elements(By.CSS_SELECTOR,".character-grid__item.character-grid__item--kanji")

        for kanji in kanjiElements:
            symbol = kanji.find_element(By.CSS_SELECTOR,".character-item__characters").text
            reading = kanji.find_element(By.CSS_SELECTOR,".character-item__info-reading").text
            meaning = kanji.find_element(By.CSS_SELECTOR,".character-item__info-meaning").text

            kanjiList.append(Kanji(symbol, reading, meaning))

        return kanjiList
        
    
    def GrabVocab(self):
        vocabList = []
        vocabElements = driver.find_elements(By.CSS_SELECTOR,".character-item.character-item--vocabulary")
        vocabElements[0].click()

        for x in range(len(vocabElements)):
            wait.until(EC.visibility_of_element_located((By.CSS_SELECTOR,"h2.subject-section__title")))
            
            meaningsAndWordType = driver.find_elements(By.CSS_SELECTOR,"p.subject-section__meanings-items")
            symbol = driver.find_element(By.CSS_SELECTOR,".character-item__characters").text
            reading = driver.find_element(By.CSS_SELECTOR,".character-item__info-reading").text
            meanings = meaningsAndWordType[0].text
            wordType = meaningsAndWordType[-1].text

            if(len(meaningsAndWordType) == 3):
                meanings += f' ({meaningsAndWordType[1].text})'


            soundLinks = driver.find_elements(By.CSS_SELECTOR,"audio.subject-readings-with-audio__audio > source[content_type *= 'audio/mpeg']")
            soundLink01 = "https://www.google.com/"
            soundLink02 = "https://www.google.com/"

            if(len(soundLinks)==1):
                soundLink01 = soundLinks[0].get_attribute("src")
            elif(len(soundLinks)==2):
                soundLink01 = soundLinks[0].get_attribute("src")
                soundLink02 = soundLinks[1].get_attribute("src")
            

            print(symbol, reading, meanings, wordType, soundLink01, soundLink02)
            vocabList.append(Vocab(symbol, reading, meanings, wordType, soundLink01, soundLink02))

            nextTermLink = driver.find_elements(By.CSS_SELECTOR, "a.subject-pager__item-link")[-1].get_attribute("href")
            driver.get(nextTermLink)
        
        return vocabList
        
  
    def Create_Cards(self, level, kanjiList, vocabList) :
        # For Study Cards, Currently Formatted For Memrise.com
        cards = open('/Users/fredericklindsey/Documents/Repositories/Completed/VocabCreatorStudy/Database/' + f"level_{level}.txt", "w+")


        for kanji in kanjiList:
            cards.write(
                    f"{kanji.symbol} (Onyomi),,,,{kanji.reading}\n" +
                    f"{kanji.symbol} (Meaning),,,,{kanji.meaning}\n")
                    

       
        for vocab in vocabList:
            cards.write(
                f"{vocab.symbol} (Furigana),,,,{vocab.reading}\n" + 
                f"{vocab.symbol} (Meaning),,,,{vocab.meanings}\n") 

        cards.close() 

    
    def Download_Sounds(self, vocabList):

        for vocab in vocabList:
            driver.get(vocab.soundLink01)
            driver.get(vocab.soundLink02)

        driver.quit()
    


        








#Script Run 
level = 30  # <-------Choose Starting Level Here 
Site = WaniKani()

Site.ENoTabi_WaniKani(level)

kanjiList = Site.GrabKanji()
vocabList = Site.GrabVocab()

Site.Create_Cards(level, kanjiList, vocabList)
Site.Download_Sounds(vocabList)    # NOTE : In order to batch download sound files the webdriver CANNOT be HEADLESS



# -------------Key------------- #

# Levels 1 => 60

#------Regex to get rid of empty lines : ^\W+?\(.+\)\s+\n------#
