<template>
  <div class="container">
    <navbar></navbar>
    <div class="grid-container">
      <div class="grid-item">
        <div class="portfolio-item-text">WIP: Online Directory</div>
        <img src="./../assets/images/portfolio/mtdir.jpg" alt="" />
      </div>
      <div class="grid-item">
        <div class="portfolio-item-text">WIP: Online Directory</div>
        <img src="./../assets/images/portfolio/mtdir.jpg" alt="" />
      </div>
      <div class="grid-item">
        <div class="portfolio-item-text">WIP: Online Directory</div>
        <img src="./../assets/images/portfolio/mtdir.jpg" alt="" />
      </div>
      <div class="grid-item">
        <div class="portfolio-item-text">WIP: Online Directory</div>
        <img src="./../assets/images/portfolio/mtdir.jpg" alt="" />
      </div>
    </div>
  </div>
</template>

<script>
import navbar from "./../components/navbar";
export default {
  components: {
    navbar
  }
};
</script>

<style lang="scss">
.grid-container {
  position: absolute;
  display: grid;
  grid-template-columns: 50% 50%;
  grid-gap: 1% 1%;
  margin-top: 10%;
  margin-left: 25%;
}

.grid-item {
  overflow: hidden;
  border-radius: 5px;
}

.grid-item img {
  border-radius: 5px;
  min-height: 300px;
  opacity: 0.8;
  transition: transform 0.5s, opacity 0.5s;
  transform: scale(1.2);
  &:hover {
    opacity: 0.9;
    transform: scale(1.1);
    cursor: pointer;
  }
}

.grid-item:hover .portfolio-item-text {
  color: #973434;
}

.portfolio-item-text {
  color: #97343478;
  z-index: 999;
  position: relative;
  width: 100%;
  top: 40%;
  left: 20%;
  font-size: 95%;
}
</style>
