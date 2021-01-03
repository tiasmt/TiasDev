<template lang="html">
  <nav class="navbar">
   
    <div class="overview">
      <h1>Tias Finks</h1>
      Curation of thoughts. <br><br>
      Feel free to visit my portfolio here. <br><br>
      Click on any of the below to filter the blog posts according to the specific criteria.

    </div>
    <ul>
      <li @click="SetActive">
        <router-link class="all" to="/">All</router-link>
      </li>
      <li @click="SetActive">
        <a class="technology">Technology</a>
      </li>
      <li @click="SetActive">
        <a class="knowledge">Knowledge</a>
      </li>
      <li @click="SetActive">
        <a class="algorithms">Algorithms</a>
      </li>
      <li @click="SetActive">
        <a class="books">Books</a>
      </li>
    </ul>
     <div class="icons">
      <a href="https://github.com/tiasmt"
        ><img src="../assets/icons/github.svg" alt="Kiwi standing on oval"
      /></a>
      <a href="https://twitter.com/tiiaasss"
        ><img src="../assets/icons/twitter.svg" alt="Kiwi standing on oval"
      /></a>
    </div>
  </nav>
</template>

<script>
export default {
   data() {
    return {
    };
  },
   methods: {
      SetActive(event) {
        var list = document.getElementsByTagName("LI");
        var filter = event.target.innerText.toLowerCase();
        list.forEach(element => {
          if(element.firstChild.classList.contains("filter-on"))
            element.firstChild.classList.remove("filter-on");
        });
        var element = event.target; 
        element.classList.add("filter-on");
        this.$store.dispatch("AddFilter", {
        filter: filter
      });
      }
   }
};
</script>

<style lang="scss" scoped>
.navbar {
  position: fixed;
  height: 100vh;
  width: 35%;
  border-right: 1px solid rgba(104, 104, 104, 0.1);
  font-size: 65%;
}
ul {
  list-style-type: none;
  position: relative;
  top: 10%;
  left: 20%;
}

a:link {
  text-decoration: none;
  color: rgb(20, 19, 19);
}

a:visited {
  text-decoration: none;
  color: rgb(20, 19, 19);
}

a {
  text-decoration: none;
  transition: 0.5s;
  cursor: pointer;
  color: rgb(20, 19, 19);
}

li a::before {
  height: 0px;
  -webkit-transition: all 300ms;
  transition: all 300ms;
  margin-top: 3px;
  margin-right: 4%;
  float: left;
  content: " ";
}

li a:hover::before {
  width: 2px;
  height: 18px;
  content: " ";
  margin-left: 3px;
}

a:active {
  margin-left: 3px;
}

li {
  margin-top: 5%;
}

img {
  width: 12%;
  margin-left: 22%;
  margin-top: 1%;
}

.icons {
  background-color: rgba(104, 104, 104, 0.1);
  height: 6%;
  bottom: 0%;
  position: absolute;
  width: 100%;
}

.overview {
  margin-top: 15%;
  text-align: center;
  width: 90%;
  margin-left: 5%;
}

.filter-on::before {
  width: 2px;
  height: 18px;
  content: " ";
  margin-left: 3px;
}

.all::before {
  background-color: rgb(236, 75, 75);
}
.portfolio::before {
  background-color: rgb(75, 158, 236);
}
.technology::before {
  background-color: rgb(136, 40, 40);
}
.knowledge::before {
  background-color: rgb(78, 163, 106);
}
.algorithms::before {
  background-color: rgb(207, 140, 52);
}
.books::before {
  background-color: rgb(47, 47, 46);
}
</style>
