import os
import re
import numpy as np
from selenium import webdriver
from selenium.webdriver.common.by import By
from selenium.webdriver.common.keys import Keys 
from selenium.webdriver.chrome.options import Options
from selenium.webdriver.support.ui import WebDriverWait
from selenium.webdriver.support import expected_conditions as EC


class Memrise : 

    @classmethod
    def ENoTabi_Memrise(self) :
        global driver
        global vocab
        options = Options()
        options.add_argument('--headless')
        options.add_argument('--disable-gpu')
        driver = webdriver.Chrome(executable_path='/Users/frederick/Documents/REPOS/WaniKani_Card_Generator/WaniKani_CardSet_Creator/chromedriver', chrome_options=options) 
        #initializing driver and driver options so it can run without opening chrome window 

        driver.get(f"https://app.memrise.com/course/2022732/japanese-1/1/")
        terms = driver.find_elements_by_css_selector('div.text > div.text')

        vocab = np.array_split(terms, len(terms)/2)

        for thing in vocab :
            print(f"{thing[0].text.strip()}\t\t{thing[1].text.strip()}")



    def Create_Cards(self, vocabulary, level) :
        cards = open(os.getcwd() + '/Memrise_Quizlet_Cards/' + f"Memrise_level_{level}.rtf", "w+")
        for thing in vocab :
            cards.write(f"{thing[0].text.strip()}\t\t{thing[1].text.strip()}\n")
        cards.close() 


script = Memrise()
script.ENoTabi_Memrise()
script.Create_Cards(vocab, "01")