import os
import re
import numpy as np
from selenium import webdriver
from selenium.webdriver.common.by import By
from selenium.webdriver.common.keys import Keys 
from selenium.webdriver.chrome.options import Options
from selenium.webdriver.support.ui import WebDriverWait
from selenium.webdriver.support import expected_conditions as EC


class iKnow : 


    @classmethod
    def ENoTabi_iKnow(self, level) :
        global driver
        options = Options()
        options.add_argument('--headless')
        options.add_argument('--disable-gpu')
        driver = webdriver.Chrome(executable_path='/Users/frederick/Documents/Repositories/VocabCreatorStudy/CardGenerators/chromedriver', chrome_options=options) 
        # initializing driver and driver options so it can run without opening chrome window 


        # Go to site and correct level page
        driver.get(f"https://app.memrise.com/course/354117/2000-italian-words-by-frequency/{level}/")


        # Collect Info
        WebDriverWait(driver, 10).until(EC.presence_of_element_located((By.CSS_SELECTOR, "div.things.clearfix")))
        driver.execute_script("window.scrollTo(0, 550)")
        terms = driver.find_elements_by_css_selector('.col_a')
        meanings = driver.find_elements_by_css_selector('.col_b')


        # Place information into file
        #this is For Quizlet
        #cards = open("/Users/frederick/Documents/Repositories/CardSet_Creator/iKnow_Quizlet_Cards/" + f"iKnow_{level}_Set{step}" + ".rtf", "w+")
        #This is For Database Tables
        cards = open("/Users/frederick/Documents/Repositories/VocabCreatorStudy/Databases/ExcelSheets/Italian_Vocab/" + "MemriseVocab" + ".txt", "a")


        for x in range(len(terms)) :
            cards.write(f"{terms[x].text}\t{meanings[x].text}\n")
            print(f"{terms[x].text}\t{meanings[x].text}\n")
            

        # Close File and Driver    
        cards.close() 
        driver.quit()



script = iKnow()
script.ENoTabi_iKnow("40")

    