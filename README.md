# ComboSkills
Все скилы создаются отдельно и могут быть обернуты в какую то дополнительную реализацию. 
После объединения они начинают действовать как один скил, вызывая свое выполнение одним методом. 
Но скил меняется на следующий после каждого применения.
-
Но есть момент, что мне не нравится - комбо-скилл содержит в себе такие же комбо-скилы и обертки вокруг них будут тоже комбо-скилы. И никак к скилу тут уже не вернутся - плохо. А если я захочу сделать "полиморфный" скилл (ну пусть 20%, что сработает более сильная версия скила), то мне предется уже писать 2 абстрактных класса, наследуюсь от скила и от комбо-скила... 
В общем, надо переделать - сделать класс комбо-скилл, который будет хранить в себе коллекцию именно скилов. Ччтобы вместо них можно было поместить эти "полиморфные" скилы.
Но наверно уже в другом проекте.
