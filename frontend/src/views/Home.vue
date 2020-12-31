<template lang="html">
  <div>
    <vue-router />
    <navbar></navbar>
    <div class="content">
      <div class="search-container">
        <input type="text" placeholder="Search..." />
        <div class="search"></div>
      </div>
      <div class="post-container">
        <ul class="post">
          <li v-for="postItem in postItems" :class="postItem.Class" :key="postItem.id">
            <img class="image" src="./../assets/images/portfolio/mtdir.jpg" alt="" />
            <div class="post-text">
              <span>
                <a href>{{ postItem.Title }}</a>
              </span>
              <div class="summary">
                Summary
              </div>
            </div>
          </li>
        </ul>
      </div>
    </div>
  </div>
</template>

<script>
import navbar from "./../components/navbar";
export default {
  name: "Home",
  components: {
    navbar
  },
  data() {
    return {
      postItems: [
        {
          Title: "Post 1",
          Class: "post-item home"
        },
        {
          Title: "Post 2",
          Class: "post-item portfolio"
        },
        {
          Title: "Post 3",
          Class: "post-item technology"
        },
        {
          Title: "Post 4",
          Class: "post-item knowledge"
        },
        {
          Title: "Post 5",
          Class: "post-item algorithms"
        },
        {
          Title: "Post 6",
          Class: "post-item books"
        }
      ]
    };
  }
};
</script>

<style lang="scss" scoped>
.search-container {
  position: absolute;
  margin-left: 35%;
  top: 5%;
  input {
    width: 150px;
    height: 35px;
    outline: none;
    border: none;
    background: rgba(180, 180, 180, 0.172);
    padding: 0 80px 0 20px;
    border-radius: 20px;
    font-size: 15px;
    &:hover {
      cursor: pointer;
    }
    &:focus {
      opacity: 1;
      cursor: text;
    }
    &::placeholder {
      opacity: 0.6;
    }
  }
}

.post-container {
  position: absolute;
  margin-top: 15%;
  margin-left: 25%;
}

.post {
  margin-top: 1%;
}



li {
  list-style-type: none;
  color: rgba(209, 46, 46, 0.5);
  font-size: 15px;
}

span {
  font-size: 18px;
  &::before {
    // content: "";
    // width: 8px;
    // height: 8px;
    // border-radius: 50%;
    // float: left;
    // margin: 10px 12px 0 0;
    // width: 3px;
    // height: 10px;
    // float: left;
    // margin: 5px 5px;
    // content: " ";
  }
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
}

.post-item {
  margin-top: 4%;
  font-size: 60%;
  width: 50vw;
  cursor: pointer;
  &::after {
     content: " ";
     width: 80%;
     height: 1px;
     display: inline-block;
     background:#29282812;
   }
}

ul:hover li {
  opacity: 0.5;
  transition: 300ms;
}
ul li:hover {
  opacity: 1;
  &::after {
    opacity: 0.7;
   }
}

.home span {
  &::before {
    background-color: #51c557c9;
  }
}
.portfolio span {
  &::before {
    background-color: rgb(75, 158, 236);
  }
}
.technology span {
  &::before {
    background-color: rgb(207, 58, 58);
  }
}
.knowledge span {
  &::before {
    background-color: rgb(78, 163, 106);
  }
}
.algorithms span {
  &::before {
    background-color: rgba(228, 166, 52, 0.938);
  }
}
.books span {
  &::before {
    background-color: rgba(47, 47, 46, 0.52);
  }
}


.home img {
 border-color:#51c557c9;
}
.portfolio img {
  border-color:rgb(75, 158, 236);
}
.technology img {
 border-color:rgb(207, 58, 58);
}
.knowledge img {
  border-color:rgb(78, 163, 106);
}
.algorithms img {
  border-color:rgba(228, 166, 52, 0.938);
}
.books img {
 border-color:rgba(47, 47, 46, 0.52);
}

.summary {
  color: rgb(58, 54, 54);
  font-size: 80%;;
}

.image {
  border: 2px solid;
  border-radius: 50%;
  height: 30px;
  width: 30px;
  float: left;
  margin-right: 2%;
}

/* Smartphones (portrait and landscape) ----------- */
@media only screen and (min-width: 320px) and (max-width: 480px) {
  /* Styles */
}

/* Smartphones (landscape) ----------- */
@media only screen and (min-width: 321px) {
  /* Styles */
}

/* Smartphones (portrait) ----------- */
@media only screen and (max-width: 320px) {
  /* Styles */
}

/* iPads (portrait and landscape) ----------- */
@media only screen and (min-width: 768px) and (max-width: 1024px) {
  /* Styles */
}

/* iPads (landscape) ----------- */
@media only screen and (min-width: 768px) and (max-width: 1024px) and (orientation: landscape) {
  /* Styles */
}

/* iPads (portrait) ----------- */
@media only screen and (min-width: 768px) and (max-width: 1024px) and (orientation: portrait) {
  /* Styles */
}

/* Desktops and laptops ----------- */
@media only screen and (min-width: 1224px) {
  /* Styles */
}

/* Large screens ----------- */
@media only screen and (min-width: 1824px) {
  /* Styles */
}

/* iPhone 4 ----------- */
@media only screen and (-webkit-min-device-pixel-ratio: 1.5),
  only screen and (min-device-pixel-ratio: 1.5) {
  /* Styles */
}
</style>
