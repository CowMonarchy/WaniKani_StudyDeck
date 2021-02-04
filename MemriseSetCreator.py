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
    def ENoTabi_iKnow(self, level, step) :
        global driver
        options = Options()
        options.add_argument('--headless')
        options.add_argument('--disable-gpu')
        driver = webdriver.Chrome(executable_path='/Users/frederick/Documents/Repositories/CardSet_Creator/chromedriver', chrome_options=options) 
        # initializing driver and driver options so it can run without opening chrome window 


        # Go to site and correct level page
        driver.get(f"https://iknow.jp/content/japanese")
        driver.execute_script("window.scrollTo(0, 550)")
        driver.find_element_by_css_selector(f"a[title *= 'Japanese Core {level}: Step {step}']").click()


        # Collect Info
        WebDriverWait(driver, 10).until(EC.presence_of_element_located((By.CSS_SELECTOR, "div.course-content")))
        driver.execute_script("window.scrollTo(0, 550)")
        terms = driver.find_elements_by_css_selector('li.item')


        # Place information into file
        cards = open("/Users/frederick/Documents/Repositories/CardSet_Creator/iKnow_Quizlet_Cards/" + f"iKnow_{level}_Set{step}" + ".rtf", "w+")

        for thing in range(100) :

            try:
                kanji = terms[thing].find_element_by_css_selector('a.cue').text
                reading = terms[thing].find_element_by_css_selector('span.transliteration').text
                translation = terms[thing].find_element_by_css_selector('p.response').text
                cards.write(f"{kanji} (Reading) \t{reading}\n{reading} (Meaning)\t{translation}\n")
                print(f"{kanji} (Reading) \t{reading}\n{reading} (Meaning)\t{translation}\n")
            except:
                kanji = terms[thing].find_element_by_css_selector('a.cue').text
                translation = terms[thing].find_element_by_css_selector('p.response').text
                cards.write(f"{kanji} (Meaning)\t{translation}\n")
                print(f"{kanji} (Meaning)\t{translation}\n")
            

        # Close File and Driver    
        cards.close() 
        driver.quit()



step = 2
script = iKnow()

for x in range(1, 11):
    script.ENoTabi_iKnow(f"6000", f"{x}")