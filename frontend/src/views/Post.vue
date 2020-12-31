<template>
  <div>
      <h1>Starting a blog</h1>
      <h2 class="date">01/01/20201</h2>
      <div class="content">
          Lorem ipsum dolor sit amet consectetur adipisicing elit. Doloribus qui sequi rem non aperiam veritatis. Nisi, aspernatur doloribus quaerat doloremque quibusdam nemo nihil sunt aperiam, beatae odio et vel soluta.
      </div>
  </div>
</template>

<script>
export default {

}
</script>

<style lang="scss" scoped>
    h1{
        margin-top: 10%;
        margin-left: 10%;
        margin-bottom: 4%;
        text-transform: uppercase;
        float: left;
        font-size: 140%;
    }

    .date {
        float: right;
        position: relative;
        color: rgb(68, 65, 65);
        font-size: 60%;
        margin-right: 15%;
        margin-top: 12%;
    }

    .content {
        margin-left: 10%;
        font-size: 70%;
        float: left;
    }
</style>