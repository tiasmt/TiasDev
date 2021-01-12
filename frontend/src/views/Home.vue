<template lang="html">
  <div>
    <navbar></navbar>
    <div v-if="loading" class="loader"><bounceloader></bounceloader></div>
    <div v-else class="content">
      <div class="search-container">
        <input v-model="Search" type="text" placeholder="Search..." />
        <div class="search"></div>
      </div>
      <div class="post-container">
          <transition-group name="fade" tag="ul" class="post">
          <li v-for="(postItem, index) in filteredPosts" :class="postItem.category" class="post-item" :key="index"  @click="openPost(postItem)" >
              <img class="image" :src="postItem.imageURL" alt="" />
              <div class="post-title">
                <span>
                  <div>{{ postItem.title }}</div>
                </span>
                <div class="summary">
                  {{ postItem.summary }}
                </div>
              </div>
          </li>
          </transition-group>       
      </div>
    </div>
  </div>
</template>

<script>
import navbar from "./../components/navbar";
import bounceloader from "./../components/bounceloader";
export default {
  name: "Home",
  components: {
    navbar,
    bounceloader,
  },
  computed: {
    loading() {
      return this.$store.state.loading;
    },
    filteredPosts() {
      this.$store.dispatch("SearchPosts", {
        search: this.Search.toLowerCase(),
      });
      return this.$store.state.filteredPosts;
    },
  },
  mounted() {
    this.$store.dispatch("GetPosts");
  },
  data() {
    return {
      Search: "",
    };
  },
  methods: {
    openPost(post) {
      this.$store.dispatch("GetPost", {
        id: post.id,
      });
    },
  },
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
  margin-left: 22%;
}

.post {
  margin-top: 1%;
}

.post-title {
  color: rgb(31, 29, 29);
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
    background: #29282812;
  }
}

ul li {
  opacity: 1;
  transition: 300ms;
}

ul:hover li {
  opacity: 0.5;
}
ul li:hover {
  opacity: 1;
  img {
    padding: 10px;
  }
  &::after {
    opacity: 0.7;
  }
}

.all span {
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

.all img {
  border-color: #51c557c9;
}
.portfolio img {
  border-color: rgb(75, 158, 236);
}
.technology img {
  border-color: rgb(207, 58, 58);
}
.knowledge img {
  border-color: rgb(78, 163, 106);
}
.algorithms img {
  border-color: rgba(228, 166, 52, 0.938);
}
.books img {
  border-color: rgba(47, 47, 46, 0.52);
}

.summary {
  color: rgb(58, 54, 54);
  margin-top: 2%;
  font-size: 70%;
}

.image {
  border: 2px solid;
  border-radius: 50%;
  height: 30px;
  width: 30px;
  float: left;
  margin-right: 2%;
  transition: 300ms;
}

.fade-enter-active,
.fade-leave-active {
  transition: opacity 1s ease;
}
.fade-enter,
.fade-leave-to {
  opacity: 0;
}

.loader {
  position: absolute;
  top: 50%;
  left: 60%;
}

/* Smartphones (portrait and landscape) ----------- */
@media only screen and (min-width: 320px) and (max-width: 480px) {
  /* Styles */
  * {
    font-size: 16px;
  }

  .search-container {
    position: relative;
    margin-left: 20%;
    margin-top: 8%;
    input {
      width: 50%;
      height: 30px;
      font-size: 13px;
    }
  }

  .post-container {
    margin-left: 10%;
    margin-top: 5%;
  }

  .post-item {
    margin-top: 8%;
    width: 75vw;
    padding: 0px;
    margin-left: 0%;
    cursor: pointer;
    &::after {
      content: " ";
      width: 65%;
      height: 1px;
      display: inline-block;
      background: #29282812;
    }
  }

  .post-title {
    margin-left: 25%;
  }

  .content {
    width: 100%;
    margin-left: 0%;
  }

  .image {
    height: 40px;
    width: 40px;
    float: left;
  }
}

/* Smartphones (landscape) ----------- */
@media only screen and (min-width: 321px) {
}

/* Smartphones (portrait) ----------- */
@media only screen and (max-width: 320px) {
  /* Styles */
}

/* iPads (portrait and landscape) ----------- */
@media only screen and (min-width: 768px) and (max-width: 1024px) {
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
